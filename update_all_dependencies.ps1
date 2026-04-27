Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

function Assert-CommandExists {
    param(
        [Parameter(Mandatory = $true)]
        [string]$CommandName
    )

    if (-not (Get-Command $CommandName -ErrorAction SilentlyContinue)) {
        throw "Required command '$CommandName' was not found in PATH."
    }
}

Assert-CommandExists -CommandName "dotnet"

$repoRoot = $PSScriptRoot
if (-not $repoRoot) {
    $repoRoot = (Get-Location).Path
}

Write-Host "Using repository root: $repoRoot" -ForegroundColor Cyan

Write-Host "Updating global tool NetDaemon.HassModel.CodeGen..." -ForegroundColor Cyan
try {
    & dotnet tool update -g NetDaemon.HassModel.CodeGen
    if ($LASTEXITCODE -ne 0) {
        throw "dotnet tool update exited with code $LASTEXITCODE"
    }
}
catch {
    Write-Warning "Could not update NetDaemon.HassModel.CodeGen. Continuing anyway. Details: $($_.Exception.Message)"
}

$projectFiles = Get-ChildItem -Path $repoRoot -Recurse -Filter "*.csproj" -File

if (-not $projectFiles -or $projectFiles.Count -eq 0) {
    Write-Warning "No .csproj files found under: $repoRoot"
    exit 0
}

Write-Host "Found $($projectFiles.Count) project(s)." -ForegroundColor Cyan

$updatedCount = 0
$failedUpdates = @()

foreach ($file in $projectFiles) {
    Write-Host ""
    Write-Host "Processing project: $($file.FullName)" -ForegroundColor Yellow

    [xml]$projectXml = Get-Content -Path $file.FullName
    $packageReferences = @(
        $projectXml.SelectNodes("//PackageReference[@Include]") |
        ForEach-Object {
            $packageName = $_.Include
            $rawVersion = $_.Version
            if (-not $rawVersion -and $_.Attributes["Version"]) {
                $rawVersion = $_.Attributes["Version"].Value
            }

            [PSCustomObject]@{
                Name = $packageName
                Version = $rawVersion
            }
        }
    ) | Group-Object Name | ForEach-Object { $_.Group[0] }

    if (-not $packageReferences -or $packageReferences.Count -eq 0) {
        Write-Host "No PackageReference entries found." -ForegroundColor DarkGray
        continue
    }

    foreach ($packageReference in $packageReferences) {
        $packageName = $packageReference.Name
        $currentVersion = $packageReference.Version
        $requestedVersion = $null
        $usePrerelease = $false

        if ($currentVersion -and $currentVersion.Contains("-")) {
            $usePrerelease = $true
        }

        if ($currentVersion -and $currentVersion -match '^(\d+)\.(\d+)\.') {
            $requestedVersion = "$($Matches[1]).$($Matches[2]).*"
            Write-Host "Updating package '$packageName' (keeping major/minor version: $requestedVersion)..." -ForegroundColor Magenta
        }
        elseif ($currentVersion -and $currentVersion -match '^(\d+)\.') {
            $requestedVersion = "$($Matches[1]).*"
            Write-Host "Updating package '$packageName' (keeping major version: $requestedVersion)..." -ForegroundColor Magenta
        }
        else {
            Write-Host "Updating package '$packageName' (latest version)..." -ForegroundColor Magenta
        }

        try {
            $arguments = @("add", $file.FullName, "package", $packageName)
            if ($requestedVersion) {
                $arguments += @("--version", $requestedVersion)
            }
            if ($usePrerelease) {
                $arguments += "--prerelease"
            }

            & dotnet @arguments
            if ($LASTEXITCODE -ne 0) {
                throw "dotnet add exited with code $LASTEXITCODE"
            }

            $updatedCount++
        }
        catch {
            $failedUpdates += [PSCustomObject]@{
                Project = $file.FullName
                Package = $packageName
                Reason = $_.Exception.Message
            }
            Write-Warning "Skipping '$packageName' in '$($file.Name)' due to update error: $($_.Exception.Message)"
        }
    }
}

Write-Host ""
Write-Host "Done. Updated $updatedCount package reference(s)." -ForegroundColor Green

if ($failedUpdates.Count -gt 0) {
    Write-Host ""
    Write-Warning "Some package updates failed:"
    foreach ($failed in $failedUpdates) {
        Write-Warning "- $($failed.Project) :: $($failed.Package)"
    }
}