namespace TibberSmartPlug.apps.Models
{
    public class PoolSchedulingSettings
    {
        public static string Name = "PoolScheduling";
        public decimal RunningPrice { get; set; }
        public int HoursToRun { get; set; }

        public decimal PumpDeviceRunningPrice { get; set; }
        public int PumpDeviceHoursToRun { get; set; }

        public string PumpDeviceEntityId { get; set; } = "switch.pool_power_switch_2";
        public string HeatingDeviceEntityId { get; set; } = "switch.pool_power_switch";

    }
}