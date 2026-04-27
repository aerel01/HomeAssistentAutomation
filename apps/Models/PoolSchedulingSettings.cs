namespace TibberSmartPlug.apps.Models
{
    public class PoolSchedulingSettings
    {
        public const string SectionName = "PoolScheduling";
        public decimal RunningPrice { get; set; }
        public int HoursToRun { get; set; }

    }
}