using TibberSmartPlug.apps.Models;
using Xunit;

namespace TibberSmartPlug.Tests;

public class PoolSchedulingSettingsTests
{
    [Fact]
    public void SectionName_ShouldMatchExpectedConfigSection()
    {
        Assert.Equal("PoolScheduling", PoolSchedulingSettings.SectionName);
    }
}
