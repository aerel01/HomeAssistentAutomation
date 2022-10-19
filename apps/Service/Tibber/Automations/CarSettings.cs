namespace NetDaemonApps.apps.Service.Tibber.Automations;

public class CarSettings {
    public static string Name = "Car";
    public bool SkipFulePrice { get; set; }
    public bool SkipPlingotPrice { get; set; }
    public decimal PlingotPrice { get; set; }
    public decimal FulePrice { get; set; }
    public decimal FuleConsumption { get; set; }
    public decimal ElectricDistance { get; set; }
}
