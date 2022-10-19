using NetDaemon.HassModel.Entities;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated;

public interface IEntities {
    AutomationEntities Automation { get; }

    BinarySensorEntities BinarySensor { get; }

    ButtonEntities Button { get; }

    CoverEntities Cover { get; }

    DeviceTrackerEntities DeviceTracker { get; }

    InputBooleanEntities InputBoolean { get; }

    InputNumberEntities InputNumber { get; }

    LightEntities Light { get; }

    NumberEntities Number { get; }

    PersistentNotificationEntities PersistentNotification { get; }

    PersonEntities Person { get; }

    SceneEntities Scene { get; }

    SensorEntities Sensor { get; }

    SunEntities Sun { get; }

    SwitchEntities Switch { get; }

    UpdateEntities Update { get; }

    WeatherEntities Weather { get; }

    ZoneEntities Zone { get; }
}

public class Entities : IEntities {
    private readonly IHaContext _haContext;

    public Entities(IHaContext haContext) {
        _haContext = haContext;
    }

    public AutomationEntities Automation => new(_haContext);
    public BinarySensorEntities BinarySensor => new(_haContext);
    public ButtonEntities Button => new(_haContext);
    public CoverEntities Cover => new(_haContext);
    public DeviceTrackerEntities DeviceTracker => new(_haContext);
    public InputBooleanEntities InputBoolean => new(_haContext);
    public InputNumberEntities InputNumber => new(_haContext);
    public LightEntities Light => new(_haContext);
    public NumberEntities Number => new(_haContext);
    public PersistentNotificationEntities PersistentNotification => new(_haContext);
    public PersonEntities Person => new(_haContext);
    public SceneEntities Scene => new(_haContext);
    public SensorEntities Sensor => new(_haContext);
    public SunEntities Sun => new(_haContext);
    public SwitchEntities Switch => new(_haContext);
    public UpdateEntities Update => new(_haContext);
    public WeatherEntities Weather => new(_haContext);
    public ZoneEntities Zone => new(_haContext);
}

public class AutomationEntities {
    private readonly IHaContext _haContext;

    public AutomationEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>balcony</summary>
    public AutomationEntity Balcony => new(_haContext, "automation.balcony");

    ///<summary>clear_log_filesize</summary>
    public AutomationEntity ClearLogFilesize => new(_haContext, "automation.clear_log_filesize");

    ///<summary>climate_safeguard</summary>
    public AutomationEntity ClimateSafeguard => new(_haContext, "automation.climate_safeguard");

    ///<summary>conditional_scan_interval</summary>
    public AutomationEntity ConditionalScanInterval => new(_haContext, "automation.conditional_scan_interval");

    ///<summary>Electricity price</summary>
    public AutomationEntity ElectricityPrice => new(_haContext, "automation.electricity_price");

    ///<summary>eq_calibration</summary>
    public AutomationEntity EqCalibration => new(_haContext, "automation.eq_calibration");

    ///<summary>fan_turn_off</summary>
    public AutomationEntity FanTurnOff => new(_haContext, "automation.fan_turn_off");

    ///<summary>fullykiosk_screensaver</summary>
    public AutomationEntity FullykioskScreensaver => new(_haContext, "automation.fullykiosk_screensaver");

    ///<summary>hacs_sensor_refresh</summary>
    public AutomationEntity HacsSensorRefresh => new(_haContext, "automation.hacs_sensor_refresh");

    ///<summary>homeassistant_start</summary>
    public AutomationEntity HomeassistantStart => new(_haContext, "automation.homeassistant_start");

    ///<summary>ios_notify_hass_update</summary>
    public AutomationEntity IosNotifyHassUpdate => new(_haContext, "automation.ios_notify_hass_update");

    ///<summary>ios_notify_hass_update_action</summary>
    public AutomationEntity IosNotifyHassUpdateAction => new(_haContext, "automation.ios_notify_hass_update_action");

    ///<summary>ios_notify_tablet_unplugged</summary>
    public AutomationEntity IosNotifyTabletUnplugged => new(_haContext, "automation.ios_notify_tablet_unplugged");

    ///<summary>laundry_alert</summary>
    public AutomationEntity LaundryAlert => new(_haContext, "automation.laundry_alert");

    ///<summary>laundry_display</summary>
    public AutomationEntity LaundryDisplay => new(_haContext, "automation.laundry_display");

    ///<summary>lovelace_updated_ignore</summary>
    public AutomationEntity LovelaceUpdatedIgnore => new(_haContext, "automation.lovelace_updated_ignore");

    ///<summary>macos_notification_motion_hall</summary>
    public AutomationEntity MacosNotificationMotionHall => new(_haContext, "automation.macos_notification_motion_hall");

    ///<summary>mailbox_count</summary>
    public AutomationEntity MailboxCount => new(_haContext, "automation.mailbox_count");

    ///<summary>monitors_volume_slider</summary>
    public AutomationEntity MonitorsVolumeSlider => new(_haContext, "automation.monitors_volume_slider");

    ///<summary>monitors_volume_update</summary>
    public AutomationEntity MonitorsVolumeUpdate => new(_haContext, "automation.monitors_volume_update");

    ///<summary>no_motion_bathroom</summary>
    public AutomationEntity NoMotionBathroom => new(_haContext, "automation.no_motion_bathroom");

    ///<summary>notify_and_remove_completed_torrent</summary>
    public AutomationEntity NotifyAndRemoveCompletedTorrent =>
        new(_haContext, "automation.notify_and_remove_completed_torrent");

    ///<summary>person_home</summary>
    public AutomationEntity PersonHome => new(_haContext, "automation.person_home");

    ///<summary>skanetrafiken_scan_interval</summary>
    public AutomationEntity SkanetrafikenScanInterval => new(_haContext, "automation.skanetrafiken_scan_interval");

    ///<summary>toast</summary>
    public AutomationEntity Toast => new(_haContext, "automation.toast");

    ///<summary>Turn Lights On at Sunset</summary>
    public AutomationEntity TurnLightsOnAtSunset => new(_haContext, "automation.turn_lights_on_at_sunset");

    ///<summary>turn_off_monitors</summary>
    public AutomationEntity TurnOffMonitors => new(_haContext, "automation.turn_off_monitors");

    ///<summary>turn_on_tv_flow</summary>
    public AutomationEntity TurnOnTvFlow => new(_haContext, "automation.turn_on_tv_flow");

    ///<summary>tv_on_lights</summary>
    public AutomationEntity TvOnLights => new(_haContext, "automation.tv_on_lights");

    ///<summary>vacuum_empty_bin</summary>
    public AutomationEntity VacuumEmptyBin => new(_haContext, "automation.vacuum_empty_bin");

    ///<summary>waste_collection</summary>
    public AutomationEntity WasteCollection => new(_haContext, "automation.waste_collection");
}

public class BinarySensorEntities {
    private readonly IHaContext _haContext;

    public BinarySensorEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>DN2103 Is Charging</summary>
    public BinarySensorEntity Dn2103IsCharging => new(_haContext, "binary_sensor.dn2103_is_charging");

    ///<summary>LE2123 Is Charging</summary>
    public BinarySensorEntity Le2123IsCharging => new(_haContext, "binary_sensor.le2123_is_charging");

    ///<summary>Minecraft Server Status</summary>
    public BinarySensorEntity MinecraftServerStatus => new(_haContext, "binary_sensor.minecraft_server_status");

    ///<summary>RPi Power status</summary>
    public BinarySensorEntity RpiPowerStatus => new(_haContext, "binary_sensor.rpi_power_status");

    public BinarySensorEntity TemplateImacVpn => new(_haContext, "binary_sensor.template_imac_vpn");
    public BinarySensorEntity TemplateUdmInternet => new(_haContext, "binary_sensor.template_udm_internet");
    public BinarySensorEntity TemplateUdmUpgradable => new(_haContext, "binary_sensor.template_udm_upgradable");

    ///<summary>Updater</summary>
    public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
}

public class ButtonEntities {
    private readonly IHaContext _haContext;

    public ButtonEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Baksida Identify</summary>
    public ButtonEntity BaksidaIdentify => new(_haContext, "button.baksida_identify");

    ///<summary>Baksida My Position</summary>
    public ButtonEntity BaksidaMyPosition => new(_haContext, "button.baksida_my_position");

    ///<summary>Framsida Identify</summary>
    public ButtonEntity FramsidaIdentify => new(_haContext, "button.framsida_identify");

    ///<summary>Framsida My Position</summary>
    public ButtonEntity FramsidaMyPosition => new(_haContext, "button.framsida_my_position");

    ///<summary>shelly1-40F5202D9010 OTA Update</summary>
    public ButtonEntity Shelly140f5202d9010OtaUpdate => new(_haContext, "button.shelly1_40f5202d9010_ota_update");

    ///<summary>shelly1-40F5202D9010 Reboot</summary>
    public ButtonEntity Shelly140f5202d9010Reboot => new(_haContext, "button.shelly1_40f5202d9010_reboot");

    ///<summary>shelly1-40F5202D9503 OTA Update</summary>
    public ButtonEntity Shelly140f5202d9503OtaUpdate => new(_haContext, "button.shelly1_40f5202d9503_ota_update");

    ///<summary>shelly1-40F5202D9503 Reboot</summary>
    public ButtonEntity Shelly140f5202d9503Reboot => new(_haContext, "button.shelly1_40f5202d9503_reboot");

    ///<summary>shelly1-8CAAB54806D5 OTA Update</summary>
    public ButtonEntity Shelly18caab54806d5OtaUpdate => new(_haContext, "button.shelly1_8caab54806d5_ota_update");

    ///<summary>shelly1-8CAAB54806D5 Reboot</summary>
    public ButtonEntity Shelly18caab54806d5Reboot => new(_haContext, "button.shelly1_8caab54806d5_reboot");

    ///<summary>Terassmarkis Identify</summary>
    public ButtonEntity TerassmarkisIdentify => new(_haContext, "button.terassmarkis_identify");

    ///<summary>Terassmarkis My Position</summary>
    public ButtonEntity TerassmarkisMyPosition => new(_haContext, "button.terassmarkis_my_position");
}

public class CoverEntities {
    private readonly IHaContext _haContext;

    public CoverEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Baksida</summary>
    public CoverEntity Baksida => new(_haContext, "cover.baksida");

    ///<summary>Baksida</summary>
    public CoverEntity Baksida2 => new(_haContext, "cover.baksida_2");

    ///<summary>Framsida</summary>
    public CoverEntity Framsida => new(_haContext, "cover.framsida");

    ///<summary>Framsida</summary>
    public CoverEntity Framsida2 => new(_haContext, "cover.framsida_2");

    ///<summary>Terassmarkis</summary>
    public CoverEntity Terassmarkis => new(_haContext, "cover.terassmarkis");
}

public class DeviceTrackerEntities {
    private readonly IHaContext _haContext;

    public DeviceTrackerEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>DN2103</summary>
    public DeviceTrackerEntity Dn2103 => new(_haContext, "device_tracker.dn2103");

    ///<summary>LE2123</summary>
    public DeviceTrackerEntity Le2123 => new(_haContext, "device_tracker.le2123");
}

public class InputBooleanEntities {
    private readonly IHaContext _haContext;

    public InputBooleanEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Avstängningslås</summary>
    public InputBooleanEntity ComputerLock => new(_haContext, "input_boolean.computer_lock");

    ///<summary>dev_netdaemon_app_model_hello_yaml_app</summary>
    public InputBooleanEntity DevNetdaemonAppModelHelloYamlApp =>
        new(_haContext, "input_boolean.dev_netdaemon_app_model_hello_yaml_app");

    ///<summary>dev_netdaemon_extensions_scheduling_scheduling_app</summary>
    public InputBooleanEntity DevNetdaemonExtensionsSchedulingSchedulingApp => new(_haContext,
        "input_boolean.dev_netdaemon_extensions_scheduling_scheduling_app");

    ///<summary>dev_netdaemon_hass_model_hello_world_app</summary>
    public InputBooleanEntity DevNetdaemonHassModelHelloWorldApp =>
        new(_haContext, "input_boolean.dev_netdaemon_hass_model_hello_world_app");

    ///<summary>dev_netdaemon_hass_model_light_on_movement</summary>
    public InputBooleanEntity DevNetdaemonHassModelLightOnMovement =>
        new(_haContext, "input_boolean.dev_netdaemon_hass_model_light_on_movement");

    ///<summary>dev_netdaemon_tibber_tibber_notification</summary>
    public InputBooleanEntity DevNetdaemonTibberTibberNotification =>
        new(_haContext, "input_boolean.dev_netdaemon_tibber_tibber_notification");

    public InputBooleanEntity LaundryDisplay => new(_haContext, "input_boolean.laundry_display");
}

public class InputNumberEntities {
    private readonly IHaContext _haContext;

    public InputNumberEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Stäng efter</summary>
    public InputNumberEntity FanTimer => new(_haContext, "input_number.fan_timer");

    ///<summary>Volym</summary>
    public InputNumberEntity MonitorsVolume => new(_haContext, "input_number.monitors_volume");
}

public class LightEntities {
    private readonly IHaContext _haContext;

    public LightEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Datorrum Tak</summary>
    public LightEntity DatorrumTak => new(_haContext, "light.datorrum_tak");

    ///<summary>Grupp Alla</summary>
    public LightEntity GruppAlla => new(_haContext, "light.grupp_alla");

    ///<summary>Grupp tak</summary>
    public LightEntity GruppTak => new(_haContext, "light.grupp_tak");

    ///<summary>Grupp tavlor</summary>
    public LightEntity GruppTavlor => new(_haContext, "light.grupp_tavlor");

    ///<summary>Grupp Tavlor</summary>
    public LightEntity GruppTavlor2 => new(_haContext, "light.grupp_tavlor_2");

    ///<summary>Hall Tavlor</summary>
    public LightEntity HallTavlor => new(_haContext, "light.hall_tavlor");

    ///<summary>Hall Tavlor</summary>
    public LightEntity HallTavlor2 => new(_haContext, "light.hall_tavlor_2");

    ///<summary>Matsal Tak</summary>
    public LightEntity MatsalTak => new(_haContext, "light.matsal_tak");

    ///<summary>Matsal Tak 1</summary>
    public LightEntity MatsalTak1 => new(_haContext, "light.matsal_tak_1");

    ///<summary>Matsal Tak 2</summary>
    public LightEntity MatsalTak2 => new(_haContext, "light.matsal_tak_2");

    ///<summary>Matsal Tavla</summary>
    public LightEntity MatsalTavla => new(_haContext, "light.matsal_tavla");

    ///<summary>Matsal Tavla</summary>
    public LightEntity MatsalTavla2 => new(_haContext, "light.matsal_tavla_2");

    ///<summary>Sovrum Taklampa</summary>
    public LightEntity SovrumTaklampa => new(_haContext, "light.sovrum_taklampa");

    ///<summary>Tak Lampa Hall</summary>
    public LightEntity TakLampaHall => new(_haContext, "light.tak_lampa_hall");

    ///<summary>Tak1</summary>
    public LightEntity Tak1 => new(_haContext, "light.tak1");

    ///<summary>Tak2</summary>
    public LightEntity Tak2 => new(_haContext, "light.tak2");
}

public class NumberEntities {
    private readonly IHaContext _haContext;

    public NumberEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Baksida My Position</summary>
    public NumberEntity BaksidaMyPosition => new(_haContext, "number.baksida_my_position");

    ///<summary>Framsida My Position</summary>
    public NumberEntity FramsidaMyPosition => new(_haContext, "number.framsida_my_position");

    ///<summary>Terassmarkis My Position</summary>
    public NumberEntity TerassmarkisMyPosition => new(_haContext, "number.terassmarkis_my_position");
}

public class PersistentNotificationEntities {
    private readonly IHaContext _haContext;

    public PersistentNotificationEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Tibber Price!</summary>
    public PersistentNotificationEntity Notification => new(_haContext, "persistent_notification.notification");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification10 => new(_haContext, "persistent_notification.notification_10");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification11 => new(_haContext, "persistent_notification.notification_11");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification12 => new(_haContext, "persistent_notification.notification_12");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification2 => new(_haContext, "persistent_notification.notification_2");

    ///<summary>Tibber Price!</summary>
    public PersistentNotificationEntity Notification3 => new(_haContext, "persistent_notification.notification_3");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification4 => new(_haContext, "persistent_notification.notification_4");

    ///<summary>Tibber Price!</summary>
    public PersistentNotificationEntity Notification5 => new(_haContext, "persistent_notification.notification_5");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification6 => new(_haContext, "persistent_notification.notification_6");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification7 => new(_haContext, "persistent_notification.notification_7");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification8 => new(_haContext, "persistent_notification.notification_8");

    ///<summary>Hello yaml app!</summary>
    public PersistentNotificationEntity Notification9 => new(_haContext, "persistent_notification.notification_9");
}

public class PersonEntities {
    private readonly IHaContext _haContext;

    public PersonEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Andreas Ekeroth</summary>
    public PersonEntity AndreasEkeroth => new(_haContext, "person.andreas_ekeroth");

    ///<summary>Oliver Ekeroth</summary>
    public PersonEntity OliverEkeroth => new(_haContext, "person.oliver_ekeroth");
}

public class SceneEntities {
    private readonly IHaContext _haContext;

    public SceneEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Släck sovrum</summary>
    public SceneEntity SlackSovrum => new(_haContext, "scene.slack_sovrum");
}

public class SensorEntities {
    private readonly IHaContext _haContext;

    public SensorEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Vet ej??? Humidity</summary>
    public NumericSensorEntity E132Humidity => new(_haContext, "sensor.132_humidity");

    ///<summary>Vet ej??? Temperature</summary>
    public NumericSensorEntity E132Temperature => new(_haContext, "sensor.132_temperature");

    ///<summary>Altan Power</summary>
    public NumericSensorEntity AltanPower => new(_haContext, "sensor.altan_power");

    ///<summary>Altan Power</summary>
    public NumericSensorEntity AltanPower2 => new(_haContext, "sensor.altan_power_2");

    ///<summary>Altan Temperature</summary>
    public NumericSensorEntity AltanTemperature => new(_haContext, "sensor.altan_temperature");

    ///<summary>Average temperature</summary>
    public NumericSensorEntity AverageTemperature => new(_haContext, "sensor.average_temperature");

    ///<summary>Baksida Humidity</summary>
    public NumericSensorEntity BaksidaHumidity => new(_haContext, "sensor.baksida_humidity");

    ///<summary>Baksida Temperature</summary>
    public NumericSensorEntity BaksidaTemperature => new(_haContext, "sensor.baksida_temperature");

    ///<summary>DN2103 Battery Level</summary>
    public NumericSensorEntity Dn2103BatteryLevel => new(_haContext, "sensor.dn2103_battery_level");

    ///<summary>DN2103 Battery Temperature</summary>
    public NumericSensorEntity Dn2103BatteryTemperature => new(_haContext, "sensor.dn2103_battery_temperature");

    ///<summary>Andreas Home Efficiency</summary>
    public NumericSensorEntity Efficiency => new(_haContext, "sensor.efficiency");

    ///<summary>Electricity price Blodrotsvägen 1</summary>
    public NumericSensorEntity ElectricityPriceBlodrotsvagen1 =>
        new(_haContext, "sensor.electricity_price_blodrotsvagen_1");

    ///<summary>Andreas Home Energy consumed</summary>
    public NumericSensorEntity EnergyConsumed => new(_haContext, "sensor.energy_consumed");

    ///<summary>Andreas Home Energy generated</summary>
    public NumericSensorEntity EnergyGenerated => new(_haContext, "sensor.energy_generated");

    ///<summary>Gavel Humidity</summary>
    public NumericSensorEntity GavelHumidity => new(_haContext, "sensor.gavel_humidity");

    ///<summary>Gavel Temperature</summary>
    public NumericSensorEntity GavelTemperature => new(_haContext, "sensor.gavel_temperature");

    ///<summary>hacs</summary>
    public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");

    ///<summary>LE2123 Battery Level</summary>
    public NumericSensorEntity Le2123BatteryLevel => new(_haContext, "sensor.le2123_battery_level");

    ///<summary>LE2123 Battery Temperature</summary>
    public NumericSensorEntity Le2123BatteryTemperature => new(_haContext, "sensor.le2123_battery_temperature");

    ///<summary>Matsal Tak 1 Power</summary>
    public NumericSensorEntity MatsalTak1Power => new(_haContext, "sensor.matsal_tak_1_power");

    ///<summary>Matsal Tak 1 Power</summary>
    public NumericSensorEntity MatsalTak1Power2 => new(_haContext, "sensor.matsal_tak_1_power_2");

    ///<summary>Minecraft Server Latency Time</summary>
    public NumericSensorEntity MinecraftServerLatencyTime => new(_haContext, "sensor.minecraft_server_latency_time");

    ///<summary>Minecraft Server Players Max</summary>
    public NumericSensorEntity MinecraftServerPlayersMax => new(_haContext, "sensor.minecraft_server_players_max");

    ///<summary>Minecraft Server Players Online</summary>
    public NumericSensorEntity MinecraftServerPlayersOnline =>
        new(_haContext, "sensor.minecraft_server_players_online");

    ///<summary>Monthly cost Blodrotsvägen 1</summary>
    public NumericSensorEntity MonthlyCostBlodrotsvagen1 => new(_haContext, "sensor.monthly_cost_blodrotsvagen_1");

    ///<summary>Monthly net consumption Blodrotsvägen 1</summary>
    public NumericSensorEntity MonthlyNetConsumptionBlodrotsvagen1 =>
        new(_haContext, "sensor.monthly_net_consumption_blodrotsvagen_1");

    ///<summary>Monthly peak hour consumption Blodrotsvägen 1</summary>
    public NumericSensorEntity MonthlyPeakHourConsumptionBlodrotsvagen1 =>
        new(_haContext, "sensor.monthly_peak_hour_consumption_blodrotsvagen_1");

    ///<summary>Pool?? Temperature</summary>
    public NumericSensorEntity PoolTemperature => new(_haContext, "sensor.pool_temperature");

    ///<summary>Pool Temperature</summary>
    public NumericSensorEntity PoolTemperature2 => new(_haContext, "sensor.pool_temperature_2");

    ///<summary>Andreas Home Power consumed</summary>
    public NumericSensorEntity PowerConsumed => new(_haContext, "sensor.power_consumed");

    ///<summary>Andreas Home Power generated</summary>
    public NumericSensorEntity PowerGenerated => new(_haContext, "sensor.power_generated");

    ///<summary>Solgivare Baksida Luminance</summary>
    public NumericSensorEntity SolgivareBaksidaLuminance => new(_haContext, "sensor.solgivare_baksida_luminance");

    ///<summary>Solgivare Framsida Luminance</summary>
    public NumericSensorEntity SolgivareFramsidaLuminance => new(_haContext, "sensor.solgivare_framsida_luminance");

    ///<summary>SpeedTest Download</summary>
    public NumericSensorEntity SpeedtestDownload => new(_haContext, "sensor.speedtest_download");

    ///<summary>SpeedTest Ping</summary>
    public NumericSensorEntity SpeedtestPing => new(_haContext, "sensor.speedtest_ping");

    ///<summary>SpeedTest Upload</summary>
    public NumericSensorEntity SpeedtestUpload => new(_haContext, "sensor.speedtest_upload");

    ///<summary>Tak1 Power</summary>
    public NumericSensorEntity Tak1Power => new(_haContext, "sensor.tak1_power");

    ///<summary>Tak1 Power</summary>
    public NumericSensorEntity Tak1Power2 => new(_haContext, "sensor.tak1_power_2");

    ///<summary>Andreas Home Temperature</summary>
    public NumericSensorEntity Temperature => new(_haContext, "sensor.temperature");

    ///<summary>Tvrum foton Power</summary>
    public NumericSensorEntity TvrumFotonPower => new(_haContext, "sensor.tvrum_foton_power");

    ///<summary>Tvrum foton Power</summary>
    public NumericSensorEntity TvrumFotonPower2 => new(_haContext, "sensor.tvrum_foton_power_2");

    ///<summary>Tvrum tak alla Power</summary>
    public NumericSensorEntity TvrumTakAllaPower => new(_haContext, "sensor.tvrum_tak_alla_power");

    ///<summary>Tvrum tak alla Power</summary>
    public NumericSensorEntity TvrumTakAllaPower2 => new(_haContext, "sensor.tvrum_tak_alla_power_2");

    ///<summary>Ute Carport Temperature</summary>
    public NumericSensorEntity UteCarportTemperature => new(_haContext, "sensor.ute_carport_temperature");

    ///<summary>Ute Framsida Humidity</summary>
    public NumericSensorEntity UteFramsidaHumidity => new(_haContext, "sensor.ute_framsida_humidity");

    ///<summary>Ute Framsida Temperature</summary>
    public NumericSensorEntity UteFramsidaTemperature => new(_haContext, "sensor.ute_framsida_temperature");

    ///<summary>Utomhusplug Power</summary>
    public NumericSensorEntity UtomhusplugPower => new(_haContext, "sensor.utomhusplug_power");

    ///<summary>Utomhusplug Power</summary>
    public NumericSensorEntity UtomhusplugPower2 => new(_haContext, "sensor.utomhusplug_power_2");

    ///<summary>Utomhusplug Power</summary>
    public NumericSensorEntity UtomhusplugPower3 => new(_haContext, "sensor.utomhusplug_power_3");

    ///<summary>Utomhusplug Power</summary>
    public NumericSensorEntity UtomhusplugPower4 => new(_haContext, "sensor.utomhusplug_power_4");

    ///<summary>Utomhusplug Power</summary>
    public NumericSensorEntity UtomhusplugPower5 => new(_haContext, "sensor.utomhusplug_power_5");

    ///<summary>Vardagsrum Humidity</summary>
    public NumericSensorEntity VardagsrumHumidity => new(_haContext, "sensor.vardagsrum_humidity");

    ///<summary>Vardagsrum Temperature</summary>
    public NumericSensorEntity VardagsrumTemperature => new(_haContext, "sensor.vardagsrum_temperature");

    ///<summary>Andreas Home Voltage</summary>
    public NumericSensorEntity Voltage => new(_haContext, "sensor.voltage");

    ///<summary>DN2103 Battery Health</summary>
    public SensorEntity Dn2103BatteryHealth => new(_haContext, "sensor.dn2103_battery_health");

    ///<summary>DN2103 Battery State</summary>
    public SensorEntity Dn2103BatteryState => new(_haContext, "sensor.dn2103_battery_state");

    ///<summary>DN2103 Charger Type</summary>
    public SensorEntity Dn2103ChargerType => new(_haContext, "sensor.dn2103_charger_type");

    ///<summary>HomeKit Setup Code</summary>
    public SensorEntity HomekitSetupCode => new(_haContext, "sensor.homekit_setup_code");

    ///<summary>LE2123 Battery Health</summary>
    public SensorEntity Le2123BatteryHealth => new(_haContext, "sensor.le2123_battery_health");

    ///<summary>LE2123 Battery State</summary>
    public SensorEntity Le2123BatteryState => new(_haContext, "sensor.le2123_battery_state");

    ///<summary>LE2123 Charger Type</summary>
    public SensorEntity Le2123ChargerType => new(_haContext, "sensor.le2123_charger_type");

    ///<summary>local_ip</summary>
    public SensorEntity LocalIp => new(_haContext, "sensor.local_ip");

    ///<summary>Minecraft Server Protocol Version</summary>
    public SensorEntity MinecraftServerProtocolVersion => new(_haContext, "sensor.minecraft_server_protocol_version");

    ///<summary>Minecraft Server Version</summary>
    public SensorEntity MinecraftServerVersion => new(_haContext, "sensor.minecraft_server_version");

    ///<summary>Minecraft Server World Message</summary>
    public SensorEntity MinecraftServerWorldMessage => new(_haContext, "sensor.minecraft_server_world_message");

    public SensorEntity TemplateDomainCounter => new(_haContext, "sensor.template_domain_counter");
    public SensorEntity TemplateFullykioskLastAppStart => new(_haContext, "sensor.template_fullykiosk_last_app_start");
    public SensorEntity TemplateFullykioskMemory => new(_haContext, "sensor.template_fullykiosk_memory");
    public SensorEntity TemplateFullykioskStorage => new(_haContext, "sensor.template_fullykiosk_storage");
    public SensorEntity TemplateHacsVersion => new(_haContext, "sensor.template_hacs_version");
    public SensorEntity TemplateHassDevRelease => new(_haContext, "sensor.template_hass_dev_release");
    public SensorEntity TemplateHassVersion => new(_haContext, "sensor.template_hass_version");
    public SensorEntity TemplateImacMacintoshHd => new(_haContext, "sensor.template_imac_macintosh_hd");
    public SensorEntity TemplateNasStatus => new(_haContext, "sensor.template_nas_status");
    public SensorEntity TemplateSidebar => new(_haContext, "sensor.template_sidebar");
    public SensorEntity TemplateUdmCpu => new(_haContext, "sensor.template_udm_cpu");
    public SensorEntity TemplateUdmCpuTemp => new(_haContext, "sensor.template_udm_cpu_temp");
    public SensorEntity TemplateUdmDisk => new(_haContext, "sensor.template_udm_disk");
    public SensorEntity TemplateUdmMem => new(_haContext, "sensor.template_udm_mem");
    public SensorEntity TemplateUdmUptime => new(_haContext, "sensor.template_udm_uptime");
    public SensorEntity TemplateUdmVersion => new(_haContext, "sensor.template_udm_version");
    public SensorEntity TemplateUpdates => new(_haContext, "sensor.template_updates");
    public SensorEntity TemplateVacuumFilter => new(_haContext, "sensor.template_vacuum_filter");
    public SensorEntity TemplateVacuumMainbrush => new(_haContext, "sensor.template_vacuum_mainbrush");
    public SensorEntity TemplateVacuumSensors => new(_haContext, "sensor.template_vacuum_sensors");
    public SensorEntity TemplateVacuumSidebrush => new(_haContext, "sensor.template_vacuum_sidebrush");

    ///<summary>Time of max hour consumption Blodrotsvägen 1</summary>
    public SensorEntity TimeOfMaxHourConsumptionBlodrotsvagen1 =>
        new(_haContext, "sensor.time_of_max_hour_consumption_blodrotsvagen_1");

    ///<summary>Utomhusplug</summary>
    public SensorEntity Utomhusplug => new(_haContext, "sensor.utomhusplug");
}

public class SunEntities {
    private readonly IHaContext _haContext;

    public SunEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Sun</summary>
    public SunEntity Sun => new(_haContext, "sun.sun");
}

public class SwitchEntities {
    private readonly IHaContext _haContext;

    public SwitchEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Altan</summary>
    public SwitchEntity Altan => new(_haContext, "switch.altan");

    ///<summary>Altan Ljusslinga</summary>
    public SwitchEntity AltanLjusslinga => new(_haContext, "switch.altan_ljusslinga");

    ///<summary>Altan Ljusslinga</summary>
    public SwitchEntity AltanLjusslinga2 => new(_haContext, "switch.altan_ljusslinga_2");

    ///<summary>Altan Tak</summary>
    public SwitchEntity AltanTak => new(_haContext, "switch.altan_tak");

    ///<summary>Altan Tak</summary>
    public SwitchEntity AltanTak2 => new(_haContext, "switch.altan_tak_2");

    ///<summary>Altan Vägglampa</summary>
    public SwitchEntity AltanVagglampa => new(_haContext, "switch.altan_vagglampa");

    ///<summary>Brand 2</summary>
    public SwitchEntity Brand2 => new(_haContext, "switch.brand_2");

    ///<summary>Carport Slinga</summary>
    public SwitchEntity CarportSlinga => new(_haContext, "switch.carport_slinga");

    ///<summary>Carport Slinga</summary>
    public SwitchEntity CarportSlinga2 => new(_haContext, "switch.carport_slinga_2");

    ///<summary>Carport Tak</summary>
    public SwitchEntity CarportTak => new(_haContext, "switch.carport_tak");

    ///<summary>Carport Tak</summary>
    public SwitchEntity CarportTak2 => new(_haContext, "switch.carport_tak_2");

    ///<summary>Datarum Golvlampa</summary>
    public SwitchEntity DatarumGolvlampa => new(_haContext, "switch.datarum_golvlampa");

    ///<summary>Datarum Tak Datorer</summary>
    public SwitchEntity DatarumTakDatorer => new(_haContext, "switch.datarum_tak_datorer");

    ///<summary>Device 38</summary>
    public SwitchEntity Device38 => new(_haContext, "switch.device_38");

    ///<summary>Device 39</summary>
    public SwitchEntity Device39 => new(_haContext, "switch.device_39");

    ///<summary>Device 40</summary>
    public SwitchEntity Device40 => new(_haContext, "switch.device_40");

    ///<summary>Utomhusplug</summary>
    public SwitchEntity Device88 => new(_haContext, "switch.device_88");

    ///<summary>Golvvärme Timer</summary>
    public SwitchEntity GolvvarmeTimer => new(_haContext, "switch.golvvarme_timer");

    ///<summary>Grup alla</summary>
    public SwitchEntity GrupAlla => new(_haContext, "switch.grup_alla");

    ///<summary>Grupp Ute</summary>
    public SwitchEntity GruppUte => new(_haContext, "switch.grupp_ute");

    ///<summary>Hall Bas</summary>
    public SwitchEntity HallBas => new(_haContext, "switch.hall_bas");

    ///<summary>Hall Byrå</summary>
    public SwitchEntity HallByra => new(_haContext, "switch.hall_byra");

    ///<summary>Hall Byrå</summary>
    public SwitchEntity HallByra2 => new(_haContext, "switch.hall_byra_2");

    ///<summary>Kök fönster</summary>
    public SwitchEntity KokFonster => new(_haContext, "switch.kok_fonster");

    ///<summary>Kök fönster</summary>
    public SwitchEntity KokFonster2 => new(_haContext, "switch.kok_fonster_2");

    ///<summary>Matsal Bas</summary>
    public SwitchEntity MatsalBas => new(_haContext, "switch.matsal_bas");

    ///<summary>Matsal Fönster</summary>
    public SwitchEntity MatsalFonster => new(_haContext, "switch.matsal_fonster");

    ///<summary>Matsal Fönster</summary>
    public SwitchEntity MatsalFonster2 => new(_haContext, "switch.matsal_fonster_2");

    ///<summary>Matsal Skrivbord</summary>
    public SwitchEntity MatsalSkrivbord => new(_haContext, "switch.matsal_skrivbord");

    ///<summary>Matsal Skrivbord</summary>
    public SwitchEntity MatsalSkrivbord2 => new(_haContext, "switch.matsal_skrivbord_2");

    ///<summary>Oliver Hylla</summary>
    public SwitchEntity OliverHylla => new(_haContext, "switch.oliver_hylla");

    ///<summary>Oliver Sänglampa</summary>
    public SwitchEntity OliverSanglampa => new(_haContext, "switch.oliver_sanglampa");

    ///<summary>shelly1-40F5202D9010</summary>
    public SwitchEntity Shelly140f5202d9010 => new(_haContext, "switch.shelly1_40f5202d9010");

    ///<summary>shelly1-40F5202D9503</summary>
    public SwitchEntity Shelly140f5202d9503 => new(_haContext, "switch.shelly1_40f5202d9503");

    ///<summary>shelly1-8CAAB54806D5</summary>
    public SwitchEntity Shelly18caab54806d5 => new(_haContext, "switch.shelly1_8caab54806d5");

    ///<summary>Sovrum Gaderob</summary>
    public SwitchEntity SovrumGaderob => new(_haContext, "switch.sovrum_gaderob");

    ///<summary>Tänd tv-rum tak extra</summary>
    public SwitchEntity TandTvRumTakExtra => new(_haContext, "switch.tand_tv_rum_tak_extra");

    ///<summary>Tänd tvrum tak</summary>
    public SwitchEntity TandTvrumTak => new(_haContext, "switch.tand_tvrum_tak");

    ///<summary>Tv-Rum bas</summary>
    public SwitchEntity TvRumBas => new(_haContext, "switch.tv_rum_bas");

    ///<summary>Tv-Rum Ljussling Tv</summary>
    public SwitchEntity TvRumLjusslingTv => new(_haContext, "switch.tv_rum_ljussling_tv");

    ///<summary>Tv-Rum Ljusslinga Tv</summary>
    public SwitchEntity TvRumLjusslingaTv => new(_haContext, "switch.tv_rum_ljusslinga_tv");

    ///<summary>Tv-Rum Yes</summary>
    public SwitchEntity TvRumYes => new(_haContext, "switch.tv_rum_yes");

    ///<summary>Tvrum foton</summary>
    public SwitchEntity TvrumFoton => new(_haContext, "switch.tvrum_foton");

    ///<summary>Tvrum foton</summary>
    public SwitchEntity TvrumFoton2 => new(_haContext, "switch.tvrum_foton_2");

    ///<summary>Tvrum ingen</summary>
    public SwitchEntity TvrumIngen => new(_haContext, "switch.tvrum_ingen");

    ///<summary>Tvrum tak</summary>
    public SwitchEntity TvrumTak => new(_haContext, "switch.tvrum_tak");

    ///<summary>Tvrum tak alla</summary>
    public SwitchEntity TvrumTakAlla => new(_haContext, "switch.tvrum_tak_alla");

    ///<summary>Tvrum tak extra</summary>
    public SwitchEntity TvrumTakExtra => new(_haContext, "switch.tvrum_tak_extra");

    ///<summary>Ute Ljusslinga pool</summary>
    public SwitchEntity UteLjusslingaPool => new(_haContext, "switch.ute_ljusslinga_pool");

    ///<summary>Ute ljusslinga växthus</summary>
    public SwitchEntity UteLjusslingaVaxthus => new(_haContext, "switch.ute_ljusslinga_vaxthus");

    ///<summary>Ute Terass</summary>
    public SwitchEntity UteTerass => new(_haContext, "switch.ute_terass");
}

public class UpdateEntities {
    private readonly IHaContext _haContext;

    public UpdateEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Home Assistant Core Update</summary>
    public UpdateEntity HomeAssistantCoreUpdate => new(_haContext, "update.home_assistant_core_update");

    ///<summary>Home Assistant Operating System Update</summary>
    public UpdateEntity HomeAssistantOperatingSystemUpdate =>
        new(_haContext, "update.home_assistant_operating_system_update");

    ///<summary>Home Assistant Supervisor Update</summary>
    public UpdateEntity HomeAssistantSupervisorUpdate => new(_haContext, "update.home_assistant_supervisor_update");

    ///<summary>Let's Encrypt Update</summary>
    public UpdateEntity LetSEncryptUpdate => new(_haContext, "update.let_s_encrypt_update");

    ///<summary>Studio Code Server Update</summary>
    public UpdateEntity StudioCodeServerUpdate => new(_haContext, "update.studio_code_server_update");

    ///<summary>Terminal & SSH Update</summary>
    public UpdateEntity TerminalSshUpdate => new(_haContext, "update.terminal_ssh_update");
}

public class WeatherEntities {
    private readonly IHaContext _haContext;

    public WeatherEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Forecast Hem</summary>
    public WeatherEntity Hem => new(_haContext, "weather.hem");

    ///<summary>Home</summary>
    public WeatherEntity SmhiHome => new(_haContext, "weather.smhi_home");
}

public class ZoneEntities {
    private readonly IHaContext _haContext;

    public ZoneEntities(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Hem</summary>
    public ZoneEntity Home => new(_haContext, "zone.home");
}

public record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes> {
    public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public AutomationEntity(Entity entity) : base(entity) {
    }
}

public record AutomationAttributes {
    [JsonPropertyName("current")]
    public double? Current { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("last_triggered")]
    public string? LastTriggered { get; init; }

    [JsonPropertyName("max")]
    public double? Max { get; init; }

    [JsonPropertyName("mode")]
    public string? Mode { get; init; }
}

public record
    BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes> {
    public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public BinarySensorEntity(Entity entity) : base(entity) {
    }
}

public record BinarySensorAttributes {
    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("restored")]
    public bool? Restored { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }
}

public record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes> {
    public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public ButtonEntity(Entity entity) : base(entity) {
    }
}

public record ButtonAttributes {
    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }
}

public record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes> {
    public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public CoverEntity(Entity entity) : base(entity) {
    }
}

public record CoverAttributes {
    [JsonPropertyName("current_position")]
    public double? CurrentPosition { get; init; }

    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("restored")]
    public bool? Restored { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }
}

public record
    DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes> {
    public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public DeviceTrackerEntity(Entity entity) : base(entity) {
    }
}

public record DeviceTrackerAttributes {
    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("source_type")]
    public string? SourceType { get; init; }
}

public record
    InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes> {
    public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public InputBooleanEntity(Entity entity) : base(entity) {
    }
}

public record InputBooleanAttributes {
    [JsonPropertyName("editable")]
    public bool? Editable { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("restored")]
    public bool? Restored { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }
}

public record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>,
    InputNumberAttributes> {
    public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public InputNumberEntity(Entity entity) : base(entity) {
    }
}

public record InputNumberAttributes {
    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("restored")]
    public bool? Restored { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }

    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }
}

public record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes> {
    public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public LightEntity(Entity entity) : base(entity) {
    }
}

public record LightAttributes {
    [JsonPropertyName("assumed_state")]
    public bool? AssumedState { get; init; }

    [JsonPropertyName("brightness")]
    public double? Brightness { get; init; }

    [JsonPropertyName("color_mode")]
    public string? ColorMode { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("supported_color_modes")]
    public IReadOnlyList<string>? SupportedColorModes { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }
}

public record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes> {
    public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public NumberEntity(Entity entity) : base(entity) {
    }
}

public record NumberAttributes {
    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("max")]
    public double? Max { get; init; }

    [JsonPropertyName("min")]
    public double? Min { get; init; }

    [JsonPropertyName("mode")]
    public string? Mode { get; init; }

    [JsonPropertyName("step")]
    public double? Step { get; init; }
}

public record PersistentNotificationEntity : Entity<PersistentNotificationEntity,
    EntityState<PersistentNotificationAttributes>, PersistentNotificationAttributes> {
    public PersistentNotificationEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public PersistentNotificationEntity(Entity entity) : base(entity) {
    }
}

public record PersistentNotificationAttributes {
    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonPropertyName("title")]
    public string? Title { get; init; }
}

public record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes> {
    public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public PersonEntity(Entity entity) : base(entity) {
    }
}

public record PersonAttributes {
    [JsonPropertyName("editable")]
    public bool? Editable { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
}

public record SceneEntity : Entity<SceneEntity, EntityState<SceneAttributes>, SceneAttributes> {
    public SceneEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public SceneEntity(Entity entity) : base(entity) {
    }
}

public record SceneAttributes {
    [JsonPropertyName("entity_id")]
    public IReadOnlyList<string>? EntityId { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("id")]
    public string? Id { get; init; }
}

public record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>,
    NumericSensorAttributes> {
    public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public NumericSensorEntity(Entity entity) : base(entity) {
    }
}

public record NumericSensorAttributes {
    [JsonPropertyName("app_nickname")]
    public object? AppNickname { get; init; }

    [JsonPropertyName("assumed_state")]
    public bool? AssumedState { get; init; }

    [JsonPropertyName("attribution")]
    public string? Attribution { get; init; }

    [JsonPropertyName("avg_price")]
    public double? AvgPrice { get; init; }

    [JsonPropertyName("bytes_received")]
    public double? BytesReceived { get; init; }

    [JsonPropertyName("bytes_sent")]
    public double? BytesSent { get; init; }

    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("estimated_annual_consumption")]
    public double? EstimatedAnnualConsumption { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("grid_company")]
    public string? GridCompany { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("max_price")]
    public double? MaxPrice { get; init; }

    [JsonPropertyName("min_price")]
    public double? MinPrice { get; init; }

    [JsonPropertyName("off_peak_1")]
    public double? OffPeak1 { get; init; }

    [JsonPropertyName("off_peak_2")]
    public double? OffPeak2 { get; init; }

    [JsonPropertyName("peak")]
    public double? Peak { get; init; }

    [JsonPropertyName("price_level")]
    public string? PriceLevel { get; init; }

    [JsonPropertyName("repositories")]
    public IReadOnlyList<object>? Repositories { get; init; }

    [JsonPropertyName("server_country")]
    public string? ServerCountry { get; init; }

    [JsonPropertyName("server_id")]
    public string? ServerId { get; init; }

    [JsonPropertyName("server_name")]
    public string? ServerName { get; init; }

    [JsonPropertyName("state_class")]
    public string? StateClass { get; init; }

    [JsonPropertyName("time_last_updated")]
    public string? TimeLastUpdated { get; init; }

    [JsonPropertyName("unit_of_measurement")]
    public string? UnitOfMeasurement { get; init; }
}

public record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes> {
    public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public SensorEntity(Entity entity) : base(entity) {
    }
}

public record SensorAttributes {
    [JsonPropertyName("assumed_state")]
    public bool? AssumedState { get; init; }

    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("restored")]
    public bool? Restored { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }

    [JsonPropertyName("time_last_updated")]
    public string? TimeLastUpdated { get; init; }
}

public record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes> {
    public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public SunEntity(Entity entity) : base(entity) {
    }
}

public record SunAttributes {
    [JsonPropertyName("azimuth")]
    public double? Azimuth { get; init; }

    [JsonPropertyName("elevation")]
    public double? Elevation { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("next_dawn")]
    public string? NextDawn { get; init; }

    [JsonPropertyName("next_dusk")]
    public string? NextDusk { get; init; }

    [JsonPropertyName("next_midnight")]
    public string? NextMidnight { get; init; }

    [JsonPropertyName("next_noon")]
    public string? NextNoon { get; init; }

    [JsonPropertyName("next_rising")]
    public string? NextRising { get; init; }

    [JsonPropertyName("next_setting")]
    public string? NextSetting { get; init; }

    [JsonPropertyName("rising")]
    public bool? Rising { get; init; }
}

public record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes> {
    public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public SwitchEntity(Entity entity) : base(entity) {
    }
}

public record SwitchAttributes {
    [JsonPropertyName("assumed_state")]
    public bool? AssumedState { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }
}

public record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes> {
    public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public UpdateEntity(Entity entity) : base(entity) {
    }
}

public record UpdateAttributes {
    [JsonPropertyName("auto_update")]
    public bool? AutoUpdate { get; init; }

    [JsonPropertyName("entity_picture")]
    public string? EntityPicture { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("in_progress")]
    public bool? InProgress { get; init; }

    [JsonPropertyName("installed_version")]
    public string? InstalledVersion { get; init; }

    [JsonPropertyName("latest_version")]
    public string? LatestVersion { get; init; }

    [JsonPropertyName("release_summary")]
    public string? ReleaseSummary { get; init; }

    [JsonPropertyName("release_url")]
    public string? ReleaseUrl { get; init; }

    [JsonPropertyName("skipped_version")]
    public object? SkippedVersion { get; init; }

    [JsonPropertyName("supported_features")]
    public double? SupportedFeatures { get; init; }

    [JsonPropertyName("title")]
    public string? Title { get; init; }
}

public record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes> {
    public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public WeatherEntity(Entity entity) : base(entity) {
    }
}

public record WeatherAttributes {
    [JsonPropertyName("attribution")]
    public string? Attribution { get; init; }

    [JsonPropertyName("cloudiness")]
    public double? Cloudiness { get; init; }

    [JsonPropertyName("forecast")]
    public IReadOnlyList<object>? Forecast { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("humidity")]
    public double? Humidity { get; init; }

    [JsonPropertyName("precipitation_unit")]
    public string? PrecipitationUnit { get; init; }

    [JsonPropertyName("pressure")]
    public double? Pressure { get; init; }

    [JsonPropertyName("pressure_unit")]
    public string? PressureUnit { get; init; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; init; }

    [JsonPropertyName("temperature_unit")]
    public string? TemperatureUnit { get; init; }

    [JsonPropertyName("thunder_probability")]
    public double? ThunderProbability { get; init; }

    [JsonPropertyName("visibility")]
    public double? Visibility { get; init; }

    [JsonPropertyName("visibility_unit")]
    public string? VisibilityUnit { get; init; }

    [JsonPropertyName("wind_bearing")]
    public double? WindBearing { get; init; }

    [JsonPropertyName("wind_gust_speed")]
    public double? WindGustSpeed { get; init; }

    [JsonPropertyName("wind_speed")]
    public double? WindSpeed { get; init; }

    [JsonPropertyName("wind_speed_unit")]
    public string? WindSpeedUnit { get; init; }
}

public record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes> {
    public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId) {
    }

    public ZoneEntity(Entity entity) : base(entity) {
    }
}

public record ZoneAttributes {
    [JsonPropertyName("editable")]
    public bool? Editable { get; init; }

    [JsonPropertyName("friendly_name")]
    public string? FriendlyName { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("latitude")]
    public double? Latitude { get; init; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; init; }

    [JsonPropertyName("passive")]
    public bool? Passive { get; init; }

    [JsonPropertyName("persons")]
    public IReadOnlyList<object>? Persons { get; init; }

    [JsonPropertyName("radius")]
    public double? Radius { get; init; }
}

public interface IServices {
    AlarmControlPanelServices AlarmControlPanel { get; }

    AutomationServices Automation { get; }

    ButtonServices Button { get; }

    ClimateServices Climate { get; }

    CloudServices Cloud { get; }

    CounterServices Counter { get; }

    CoverServices Cover { get; }

    DeviceTrackerServices DeviceTracker { get; }

    FfmpegServices Ffmpeg { get; }

    FrontendServices Frontend { get; }

    GroupServices Group { get; }

    HassioServices Hassio { get; }

    HomeassistantServices Homeassistant { get; }

    InputBooleanServices InputBoolean { get; }

    InputButtonServices InputButton { get; }

    InputDatetimeServices InputDatetime { get; }

    InputNumberServices InputNumber { get; }

    InputSelectServices InputSelect { get; }

    InputTextServices InputText { get; }

    LightServices Light { get; }

    LockServices Lock { get; }

    LogbookServices Logbook { get; }

    LovelaceServices Lovelace { get; }

    NotifyServices Notify { get; }

    NumberServices Number { get; }

    PersistentNotificationServices PersistentNotification { get; }

    PersonServices Person { get; }

    PythonScriptServices PythonScript { get; }

    RecorderServices Recorder { get; }

    SceneServices Scene { get; }

    ScriptServices Script { get; }

    SelectServices Select { get; }

    SirenServices Siren { get; }

    SpeedtestdotnetServices Speedtestdotnet { get; }

    SwitchServices Switch { get; }

    SystemLogServices SystemLog { get; }

    TemplateServices Template { get; }

    TimerServices Timer { get; }

    TtsServices Tts { get; }

    UpdateServices Update { get; }

    ZoneServices Zone { get; }
}

public class Services : IServices {
    private readonly IHaContext _haContext;

    public Services(IHaContext haContext) {
        _haContext = haContext;
    }

    public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
    public AutomationServices Automation => new(_haContext);
    public ButtonServices Button => new(_haContext);
    public ClimateServices Climate => new(_haContext);
    public CloudServices Cloud => new(_haContext);
    public CounterServices Counter => new(_haContext);
    public CoverServices Cover => new(_haContext);
    public DeviceTrackerServices DeviceTracker => new(_haContext);
    public FfmpegServices Ffmpeg => new(_haContext);
    public FrontendServices Frontend => new(_haContext);
    public GroupServices Group => new(_haContext);
    public HassioServices Hassio => new(_haContext);
    public HomeassistantServices Homeassistant => new(_haContext);
    public InputBooleanServices InputBoolean => new(_haContext);
    public InputButtonServices InputButton => new(_haContext);
    public InputDatetimeServices InputDatetime => new(_haContext);
    public InputNumberServices InputNumber => new(_haContext);
    public InputSelectServices InputSelect => new(_haContext);
    public InputTextServices InputText => new(_haContext);
    public LightServices Light => new(_haContext);
    public LockServices Lock => new(_haContext);
    public LogbookServices Logbook => new(_haContext);
    public LovelaceServices Lovelace => new(_haContext);
    public NotifyServices Notify => new(_haContext);
    public NumberServices Number => new(_haContext);
    public PersistentNotificationServices PersistentNotification => new(_haContext);
    public PersonServices Person => new(_haContext);
    public PythonScriptServices PythonScript => new(_haContext);
    public RecorderServices Recorder => new(_haContext);
    public SceneServices Scene => new(_haContext);
    public ScriptServices Script => new(_haContext);
    public SelectServices Select => new(_haContext);
    public SirenServices Siren => new(_haContext);
    public SpeedtestdotnetServices Speedtestdotnet => new(_haContext);
    public SwitchServices Switch => new(_haContext);
    public SystemLogServices SystemLog => new(_haContext);
    public TemplateServices Template => new(_haContext);
    public TimerServices Timer => new(_haContext);
    public TtsServices Tts => new(_haContext);
    public UpdateServices Update => new(_haContext);
    public ZoneServices Zone => new(_haContext);
}

public class AlarmControlPanelServices {
    private readonly IHaContext _haContext;

    public AlarmControlPanelServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Send the alarm the command for arm away.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
    }

    ///<summary>Send the alarm the command for arm away.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
    public void AlarmArmAway(ServiceTarget target, string? code = null) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_away", target,
            new AlarmControlPanelAlarmArmAwayParameters { Code = code });
    }

    ///<summary>Send arm custom bypass command.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
    }

    ///<summary>Send arm custom bypass command.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
    public void AlarmArmCustomBypass(ServiceTarget target, string? code = null) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target,
            new AlarmControlPanelAlarmArmCustomBypassParameters { Code = code });
    }

    ///<summary>Send the alarm the command for arm home.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
    }

    ///<summary>Send the alarm the command for arm home.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
    public void AlarmArmHome(ServiceTarget target, string? code = null) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_home", target,
            new AlarmControlPanelAlarmArmHomeParameters { Code = code });
    }

    ///<summary>Send the alarm the command for arm night.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
    }

    ///<summary>Send the alarm the command for arm night.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
    public void AlarmArmNight(ServiceTarget target, string? code = null) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_night", target,
            new AlarmControlPanelAlarmArmNightParameters { Code = code });
    }

    ///<summary>Send the alarm the command for arm vacation.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
    }

    ///<summary>Send the alarm the command for arm vacation.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
    public void AlarmArmVacation(ServiceTarget target, string? code = null) {
        _haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target,
            new AlarmControlPanelAlarmArmVacationParameters { Code = code });
    }

    ///<summary>Send the alarm the command for disarm.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data) {
        _haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
    }

    ///<summary>Send the alarm the command for disarm.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
    public void AlarmDisarm(ServiceTarget target, string? code = null) {
        _haContext.CallService("alarm_control_panel", "alarm_disarm", target,
            new AlarmControlPanelAlarmDisarmParameters { Code = code });
    }

    ///<summary>Send the alarm the command for trigger.</summary>
    ///<param name="target">The target for this service call</param>
    public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data) {
        _haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
    }

    ///<summary>Send the alarm the command for trigger.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
    public void AlarmTrigger(ServiceTarget target, string? code = null) {
        _haContext.CallService("alarm_control_panel", "alarm_trigger", target,
            new AlarmControlPanelAlarmTriggerParameters { Code = code });
    }
}

public record AlarmControlPanelAlarmArmAwayParameters {
    ///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public record AlarmControlPanelAlarmArmCustomBypassParameters {
    ///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public record AlarmControlPanelAlarmArmHomeParameters {
    ///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public record AlarmControlPanelAlarmArmNightParameters {
    ///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public record AlarmControlPanelAlarmArmVacationParameters {
    ///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public record AlarmControlPanelAlarmDisarmParameters {
    ///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public record AlarmControlPanelAlarmTriggerParameters {
    ///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public class AutomationServices {
    private readonly IHaContext _haContext;

    public AutomationServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload the automation configuration.</summary>
    public void Reload() {
        _haContext.CallService("automation", "reload");
    }

    ///<summary>Toggle (enable / disable) an automation.</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target) {
        _haContext.CallService("automation", "toggle", target);
    }

    ///<summary>Trigger the actions of an automation.</summary>
    ///<param name="target">The target for this service call</param>
    public void Trigger(ServiceTarget target, AutomationTriggerParameters data) {
        _haContext.CallService("automation", "trigger", target, data);
    }

    ///<summary>Trigger the actions of an automation.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
    public void Trigger(ServiceTarget target, bool? skipCondition = null) {
        _haContext.CallService("automation", "trigger", target,
            new AutomationTriggerParameters { SkipCondition = skipCondition });
    }

    ///<summary>Disable an automation.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data) {
        _haContext.CallService("automation", "turn_off", target, data);
    }

    ///<summary>Disable an automation.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="stopActions">Stop currently running actions.</param>
    public void TurnOff(ServiceTarget target, bool? stopActions = null) {
        _haContext.CallService("automation", "turn_off", target,
            new AutomationTurnOffParameters { StopActions = stopActions });
    }

    ///<summary>Enable an automation.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target) {
        _haContext.CallService("automation", "turn_on", target);
    }
}

public record AutomationTriggerParameters {
    ///<summary>Whether or not the conditions will be skipped.</summary>
    [JsonPropertyName("skip_condition")]
    public bool? SkipCondition { get; init; }
}

public record AutomationTurnOffParameters {
    ///<summary>Stop currently running actions.</summary>
    [JsonPropertyName("stop_actions")]
    public bool? StopActions { get; init; }
}

public class ButtonServices {
    private readonly IHaContext _haContext;

    public ButtonServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Press the button entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void Press(ServiceTarget target) {
        _haContext.CallService("button", "press", target);
    }
}

public class ClimateServices {
    private readonly IHaContext _haContext;

    public ClimateServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Turn auxiliary heater on/off for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data) {
        _haContext.CallService("climate", "set_aux_heat", target, data);
    }

    ///<summary>Turn auxiliary heater on/off for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="auxHeat">New value of auxiliary heater.</param>
    public void SetAuxHeat(ServiceTarget target, bool auxHeat) {
        _haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters { AuxHeat = auxHeat });
    }

    ///<summary>Set fan operation for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data) {
        _haContext.CallService("climate", "set_fan_mode", target, data);
    }

    ///<summary>Set fan operation for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="fanMode">New value of fan mode. eg: low</param>
    public void SetFanMode(ServiceTarget target, string fanMode) {
        _haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters { FanMode = fanMode });
    }

    ///<summary>Set target humidity of climate device.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data) {
        _haContext.CallService("climate", "set_humidity", target, data);
    }

    ///<summary>Set target humidity of climate device.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="humidity">New target humidity for climate device.</param>
    public void SetHumidity(ServiceTarget target, long humidity) {
        _haContext.CallService("climate", "set_humidity", target,
            new ClimateSetHumidityParameters { Humidity = humidity });
    }

    ///<summary>Set HVAC operation mode for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data) {
        _haContext.CallService("climate", "set_hvac_mode", target, data);
    }

    ///<summary>Set HVAC operation mode for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="hvacMode">New value of operation mode.</param>
    public void SetHvacMode(ServiceTarget target, object? hvacMode = null) {
        _haContext.CallService("climate", "set_hvac_mode", target,
            new ClimateSetHvacModeParameters { HvacMode = hvacMode });
    }

    ///<summary>Set preset mode for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data) {
        _haContext.CallService("climate", "set_preset_mode", target, data);
    }

    ///<summary>Set preset mode for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="presetMode">New value of preset mode. eg: away</param>
    public void SetPresetMode(ServiceTarget target, string presetMode) {
        _haContext.CallService("climate", "set_preset_mode", target,
            new ClimateSetPresetModeParameters { PresetMode = presetMode });
    }

    ///<summary>Set swing operation for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data) {
        _haContext.CallService("climate", "set_swing_mode", target, data);
    }

    ///<summary>Set swing operation for climate device.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="swingMode">New value of swing mode. eg: horizontal</param>
    public void SetSwingMode(ServiceTarget target, string swingMode) {
        _haContext.CallService("climate", "set_swing_mode", target,
            new ClimateSetSwingModeParameters { SwingMode = swingMode });
    }

    ///<summary>Set target temperature of climate device.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data) {
        _haContext.CallService("climate", "set_temperature", target, data);
    }

    ///<summary>Set target temperature of climate device.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="temperature">New target temperature for HVAC.</param>
    ///<param name="targetTempHigh">New target high temperature for HVAC.</param>
    ///<param name="targetTempLow">New target low temperature for HVAC.</param>
    ///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
    public void SetTemperature(
        ServiceTarget target,
        double? temperature = null,
        double? targetTempHigh = null,
        double? targetTempLow = null,
        object? hvacMode = null) {
        _haContext.CallService("climate", "set_temperature", target,
            new ClimateSetTemperatureParameters {
                Temperature = temperature, TargetTempHigh = targetTempHigh, TargetTempLow = targetTempLow,
                HvacMode = hvacMode,
            });
    }

    ///<summary>Turn climate device off.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target) {
        _haContext.CallService("climate", "turn_off", target);
    }

    ///<summary>Turn climate device on.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target) {
        _haContext.CallService("climate", "turn_on", target);
    }
}

public record ClimateSetAuxHeatParameters {
    ///<summary>New value of auxiliary heater.</summary>
    [JsonPropertyName("aux_heat")]
    public bool? AuxHeat { get; init; }
}

public record ClimateSetFanModeParameters {
    ///<summary>New value of fan mode. eg: low</summary>
    [JsonPropertyName("fan_mode")]
    public string? FanMode { get; init; }
}

public record ClimateSetHumidityParameters {
    ///<summary>New target humidity for climate device.</summary>
    [JsonPropertyName("humidity")]
    public long? Humidity { get; init; }
}

public record ClimateSetHvacModeParameters {
    ///<summary>New value of operation mode.</summary>
    [JsonPropertyName("hvac_mode")]
    public object? HvacMode { get; init; }
}

public record ClimateSetPresetModeParameters {
    ///<summary>New value of preset mode. eg: away</summary>
    [JsonPropertyName("preset_mode")]
    public string? PresetMode { get; init; }
}

public record ClimateSetSwingModeParameters {
    ///<summary>New value of swing mode. eg: horizontal</summary>
    [JsonPropertyName("swing_mode")]
    public string? SwingMode { get; init; }
}

public record ClimateSetTemperatureParameters {
    ///<summary>New target temperature for HVAC.</summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; init; }

    ///<summary>New target high temperature for HVAC.</summary>
    [JsonPropertyName("target_temp_high")]
    public double? TargetTempHigh { get; init; }

    ///<summary>New target low temperature for HVAC.</summary>
    [JsonPropertyName("target_temp_low")]
    public double? TargetTempLow { get; init; }

    ///<summary>HVAC operation mode to set temperature to.</summary>
    [JsonPropertyName("hvac_mode")]
    public object? HvacMode { get; init; }
}

public class CloudServices {
    private readonly IHaContext _haContext;

    public CloudServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Make instance UI available outside over NabuCasa cloud</summary>
    public void RemoteConnect() {
        _haContext.CallService("cloud", "remote_connect");
    }

    ///<summary>Disconnect UI from NabuCasa cloud</summary>
    public void RemoteDisconnect() {
        _haContext.CallService("cloud", "remote_disconnect");
    }
}

public class CounterServices {
    private readonly IHaContext _haContext;

    public CounterServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Change counter parameters.</summary>
    ///<param name="target">The target for this service call</param>
    public void Configure(ServiceTarget target, CounterConfigureParameters data) {
        _haContext.CallService("counter", "configure", target, data);
    }

    ///<summary>Change counter parameters.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
    ///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
    ///<param name="step">New value for step.</param>
    ///<param name="initial">New value for initial.</param>
    ///<param name="value">New state value.</param>
    public void Configure(
        ServiceTarget target,
        long? minimum = null,
        long? maximum = null,
        long? step = null,
        long? initial = null,
        long? value = null) {
        _haContext.CallService("counter", "configure", target,
            new CounterConfigureParameters { Minimum = minimum, Maximum = maximum, Step = step, Initial = initial, Value = value });
    }

    ///<summary>Decrement a counter.</summary>
    ///<param name="target">The target for this service call</param>
    public void Decrement(ServiceTarget target) {
        _haContext.CallService("counter", "decrement", target);
    }

    ///<summary>Increment a counter.</summary>
    ///<param name="target">The target for this service call</param>
    public void Increment(ServiceTarget target) {
        _haContext.CallService("counter", "increment", target);
    }

    ///<summary>Reset a counter.</summary>
    ///<param name="target">The target for this service call</param>
    public void Reset(ServiceTarget target) {
        _haContext.CallService("counter", "reset", target);
    }
}

public record CounterConfigureParameters {
    ///<summary>New minimum value for the counter or None to remove minimum.</summary>
    [JsonPropertyName("minimum")]
    public long? Minimum { get; init; }

    ///<summary>New maximum value for the counter or None to remove maximum.</summary>
    [JsonPropertyName("maximum")]
    public long? Maximum { get; init; }

    ///<summary>New value for step.</summary>
    [JsonPropertyName("step")]
    public long? Step { get; init; }

    ///<summary>New value for initial.</summary>
    [JsonPropertyName("initial")]
    public long? Initial { get; init; }

    ///<summary>New state value.</summary>
    [JsonPropertyName("value")]
    public long? Value { get; init; }
}

public class CoverServices {
    private readonly IHaContext _haContext;

    public CoverServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Close all or specified cover.</summary>
    ///<param name="target">The target for this service call</param>
    public void CloseCover(ServiceTarget target) {
        _haContext.CallService("cover", "close_cover", target);
    }

    ///<summary>Close all or specified cover tilt.</summary>
    ///<param name="target">The target for this service call</param>
    public void CloseCoverTilt(ServiceTarget target) {
        _haContext.CallService("cover", "close_cover_tilt", target);
    }

    ///<summary>Open all or specified cover.</summary>
    ///<param name="target">The target for this service call</param>
    public void OpenCover(ServiceTarget target) {
        _haContext.CallService("cover", "open_cover", target);
    }

    ///<summary>Open all or specified cover tilt.</summary>
    ///<param name="target">The target for this service call</param>
    public void OpenCoverTilt(ServiceTarget target) {
        _haContext.CallService("cover", "open_cover_tilt", target);
    }

    ///<summary>Move to specific position all or specified cover.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data) {
        _haContext.CallService("cover", "set_cover_position", target, data);
    }

    ///<summary>Move to specific position all or specified cover.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="position">Position of the cover</param>
    public void SetCoverPosition(ServiceTarget target, long position) {
        _haContext.CallService("cover", "set_cover_position", target,
            new CoverSetCoverPositionParameters { Position = position });
    }

    ///<summary>Move to specific position all or specified cover tilt.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data) {
        _haContext.CallService("cover", "set_cover_tilt_position", target, data);
    }

    ///<summary>Move to specific position all or specified cover tilt.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="tiltPosition">Tilt position of the cover.</param>
    public void SetCoverTiltPosition(ServiceTarget target, long tiltPosition) {
        _haContext.CallService("cover", "set_cover_tilt_position", target,
            new CoverSetCoverTiltPositionParameters { TiltPosition = tiltPosition });
    }

    ///<summary>Stop all or specified cover.</summary>
    ///<param name="target">The target for this service call</param>
    public void StopCover(ServiceTarget target) {
        _haContext.CallService("cover", "stop_cover", target);
    }

    ///<summary>Stop all or specified cover.</summary>
    ///<param name="target">The target for this service call</param>
    public void StopCoverTilt(ServiceTarget target) {
        _haContext.CallService("cover", "stop_cover_tilt", target);
    }

    ///<summary>Toggle a cover open/closed.</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target) {
        _haContext.CallService("cover", "toggle", target);
    }

    ///<summary>Toggle a cover tilt open/closed.</summary>
    ///<param name="target">The target for this service call</param>
    public void ToggleCoverTilt(ServiceTarget target) {
        _haContext.CallService("cover", "toggle_cover_tilt", target);
    }
}

public record CoverSetCoverPositionParameters {
    ///<summary>Position of the cover</summary>
    [JsonPropertyName("position")]
    public long? Position { get; init; }
}

public record CoverSetCoverTiltPositionParameters {
    ///<summary>Tilt position of the cover.</summary>
    [JsonPropertyName("tilt_position")]
    public long? TiltPosition { get; init; }
}

public class DeviceTrackerServices {
    private readonly IHaContext _haContext;

    public DeviceTrackerServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Control tracked device.</summary>
    public void See(DeviceTrackerSeeParameters data) {
        _haContext.CallService("device_tracker", "see", target: null, data);
    }

    ///<summary>Control tracked device.</summary>
    ///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
    ///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
    ///<param name="hostName">Hostname of device eg: Dave</param>
    ///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
    ///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
    ///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
    ///<param name="battery">Battery level of device.</param>
    public void See(
        string? mac = null,
        string? devId = null,
        string? hostName = null,
        string? locationName = null,
        object? gps = null,
        long? gpsAccuracy = null,
        long? battery = null) {
        _haContext.CallService("device_tracker", "see", target: null,
            new DeviceTrackerSeeParameters {
                Mac = mac, DevId = devId, HostName = hostName, LocationName = locationName, Gps = gps,
                GpsAccuracy = gpsAccuracy, Battery = battery,
            });
    }
}

public record DeviceTrackerSeeParameters {
    ///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
    [JsonPropertyName("mac")]
    public string? Mac { get; init; }

    ///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
    [JsonPropertyName("dev_id")]
    public string? DevId { get; init; }

    ///<summary>Hostname of device eg: Dave</summary>
    [JsonPropertyName("host_name")]
    public string? HostName { get; init; }

    ///<summary>Name of location where device is located (not_home is away). eg: home</summary>
    [JsonPropertyName("location_name")]
    public string? LocationName { get; init; }

    ///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
    [JsonPropertyName("gps")]
    public object? Gps { get; init; }

    ///<summary>Accuracy of GPS coordinates.</summary>
    [JsonPropertyName("gps_accuracy")]
    public long? GpsAccuracy { get; init; }

    ///<summary>Battery level of device.</summary>
    [JsonPropertyName("battery")]
    public long? Battery { get; init; }
}

public class FfmpegServices {
    private readonly IHaContext _haContext;

    public FfmpegServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Send a restart command to a ffmpeg based sensor.</summary>
    public void Restart(FfmpegRestartParameters data) {
        _haContext.CallService("ffmpeg", "restart", target: null, data);
    }

    ///<summary>Send a restart command to a ffmpeg based sensor.</summary>
    ///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
    public void Restart(string? entityId = null) {
        _haContext.CallService("ffmpeg", "restart", target: null, new FfmpegRestartParameters { EntityId = entityId });
    }

    ///<summary>Send a start command to a ffmpeg based sensor.</summary>
    public void Start(FfmpegStartParameters data) {
        _haContext.CallService("ffmpeg", "start", target: null, data);
    }

    ///<summary>Send a start command to a ffmpeg based sensor.</summary>
    ///<param name="entityId">Name of entity that will start. Platform dependent.</param>
    public void Start(string? entityId = null) {
        _haContext.CallService("ffmpeg", "start", target: null, new FfmpegStartParameters { EntityId = entityId });
    }

    ///<summary>Send a stop command to a ffmpeg based sensor.</summary>
    public void Stop(FfmpegStopParameters data) {
        _haContext.CallService("ffmpeg", "stop", target: null, data);
    }

    ///<summary>Send a stop command to a ffmpeg based sensor.</summary>
    ///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
    public void Stop(string? entityId = null) {
        _haContext.CallService("ffmpeg", "stop", target: null, new FfmpegStopParameters { EntityId = entityId });
    }
}

public record FfmpegRestartParameters {
    ///<summary>Name of entity that will restart. Platform dependent.</summary>
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }
}

public record FfmpegStartParameters {
    ///<summary>Name of entity that will start. Platform dependent.</summary>
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }
}

public record FfmpegStopParameters {
    ///<summary>Name of entity that will stop. Platform dependent.</summary>
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }
}

public class FrontendServices {
    private readonly IHaContext _haContext;

    public FrontendServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload themes from YAML configuration.</summary>
    public void ReloadThemes() {
        _haContext.CallService("frontend", "reload_themes");
    }

    ///<summary>Set a theme unless the client selected per-device theme.</summary>
    public void SetTheme(FrontendSetThemeParameters data) {
        _haContext.CallService("frontend", "set_theme", target: null, data);
    }

    ///<summary>Set a theme unless the client selected per-device theme.</summary>
    ///<param name="name">Name of a predefined theme eg: default</param>
    ///<param name="mode">The mode the theme is for.</param>
    public void SetTheme(object name, object? mode = null) {
        _haContext.CallService("frontend", "set_theme", target: null,
            new FrontendSetThemeParameters { Name = name, Mode = mode });
    }
}

public record FrontendSetThemeParameters {
    ///<summary>Name of a predefined theme eg: default</summary>
    [JsonPropertyName("name")]
    public object? Name { get; init; }

    ///<summary>The mode the theme is for.</summary>
    [JsonPropertyName("mode")]
    public object? Mode { get; init; }
}

public class GroupServices {
    private readonly IHaContext _haContext;

    public GroupServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload group configuration, entities, and notify services.</summary>
    public void Reload() {
        _haContext.CallService("group", "reload");
    }

    ///<summary>Remove a user group.</summary>
    public void Remove(GroupRemoveParameters data) {
        _haContext.CallService("group", "remove", target: null, data);
    }

    ///<summary>Remove a user group.</summary>
    ///<param name="objectId">Group id and part of entity id. eg: test_group</param>
    public void Remove(object objectId) {
        _haContext.CallService("group", "remove", target: null, new GroupRemoveParameters { ObjectId = objectId });
    }

    ///<summary>Create/Update a user group.</summary>
    public void Set(GroupSetParameters data) {
        _haContext.CallService("group", "set", target: null, data);
    }

    /// <summary>Create/Update a user group.</summary>
    /// <param name="objectId">Group id and part of entity id. eg: test_group</param>
    /// <param name="name">Name of group eg: My test group</param>
    /// <param name="icon">Name of icon for the group. eg: mdi:camera</param>
    /// <param name="entities">
    ///     List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1,
    ///     domain.entity_id2
    /// </param>
    /// <param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
    /// <param name="all">Enable this option if the group should only turn on when all entities are on.</param>
    public void Set(
        string objectId,
        string? name = null,
        object? icon = null,
        object? entities = null,
        object? addEntities = null,
        bool? all = null) {
        _haContext.CallService("group", "set", target: null,
            new GroupSetParameters {
                ObjectId = objectId, Name = name, Icon = icon, Entities = entities, AddEntities = addEntities, All = all,
            });
    }
}

public record GroupRemoveParameters {
    ///<summary>Group id and part of entity id. eg: test_group</summary>
    [JsonPropertyName("object_id")]
    public object? ObjectId { get; init; }
}

public record GroupSetParameters {
    ///<summary>Group id and part of entity id. eg: test_group</summary>
    [JsonPropertyName("object_id")]
    public string? ObjectId { get; init; }

    ///<summary>Name of group eg: My test group</summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    ///<summary>Name of icon for the group. eg: mdi:camera</summary>
    [JsonPropertyName("icon")]
    public object? Icon { get; init; }

    ///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
    [JsonPropertyName("entities")]
    public object? Entities { get; init; }

    ///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
    [JsonPropertyName("add_entities")]
    public object? AddEntities { get; init; }

    ///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
    [JsonPropertyName("all")]
    public bool? All { get; init; }
}

public class HassioServices {
    private readonly IHaContext _haContext;

    public HassioServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Restart add-on.</summary>
    public void AddonRestart(HassioAddonRestartParameters data) {
        _haContext.CallService("hassio", "addon_restart", target: null, data);
    }

    ///<summary>Restart add-on.</summary>
    ///<param name="addon">The add-on slug. eg: core_ssh</param>
    public void AddonRestart(string addon) {
        _haContext.CallService("hassio", "addon_restart", target: null,
            new HassioAddonRestartParameters { Addon = addon });
    }

    ///<summary>Start add-on.</summary>
    public void AddonStart(HassioAddonStartParameters data) {
        _haContext.CallService("hassio", "addon_start", target: null, data);
    }

    ///<summary>Start add-on.</summary>
    ///<param name="addon">The add-on slug. eg: core_ssh</param>
    public void AddonStart(string addon) {
        _haContext.CallService("hassio", "addon_start", target: null, new HassioAddonStartParameters { Addon = addon });
    }

    ///<summary>Write data to add-on stdin.</summary>
    public void AddonStdin(HassioAddonStdinParameters data) {
        _haContext.CallService("hassio", "addon_stdin", target: null, data);
    }

    ///<summary>Write data to add-on stdin.</summary>
    ///<param name="addon">The add-on slug. eg: core_ssh</param>
    public void AddonStdin(string addon) {
        _haContext.CallService("hassio", "addon_stdin", target: null, new HassioAddonStdinParameters { Addon = addon });
    }

    ///<summary>Stop add-on.</summary>
    public void AddonStop(HassioAddonStopParameters data) {
        _haContext.CallService("hassio", "addon_stop", target: null, data);
    }

    ///<summary>Stop add-on.</summary>
    ///<param name="addon">The add-on slug. eg: core_ssh</param>
    public void AddonStop(string addon) {
        _haContext.CallService("hassio", "addon_stop", target: null, new HassioAddonStopParameters { Addon = addon });
    }

    /// <summary>
    ///     Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It
    ///     is highly recommended that you review release notes/change logs before updating an add-on.
    /// </summary>
    public void AddonUpdate(HassioAddonUpdateParameters data) {
        _haContext.CallService("hassio", "addon_update", target: null, data);
    }

    /// <summary>
    ///     Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It
    ///     is highly recommended that you review release notes/change logs before updating an add-on.
    /// </summary>
    /// <param name="addon">The add-on slug. eg: core_ssh</param>
    public void AddonUpdate(string addon) {
        _haContext.CallService("hassio", "addon_update", target: null, new HassioAddonUpdateParameters { Addon = addon });
    }

    ///<summary>Create a full backup.</summary>
    public void BackupFull(HassioBackupFullParameters data) {
        _haContext.CallService("hassio", "backup_full", target: null, data);
    }

    ///<summary>Create a full backup.</summary>
    ///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
    ///<param name="password">Optional password. eg: password</param>
    ///<param name="compressed">Use compressed archives</param>
    public void BackupFull(string? name = null, string? password = null, bool? compressed = null) {
        _haContext.CallService("hassio", "backup_full", target: null,
            new HassioBackupFullParameters { Name = name, Password = password, Compressed = compressed });
    }

    ///<summary>Create a partial backup.</summary>
    public void BackupPartial(HassioBackupPartialParameters data) {
        _haContext.CallService("hassio", "backup_partial", target: null, data);
    }

    ///<summary>Create a partial backup.</summary>
    ///<param name="homeassistant">Backup Home Assistant settings</param>
    ///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
    ///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
    ///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
    ///<param name="password">Optional password. eg: password</param>
    ///<param name="compressed">Use compressed archives</param>
    public void BackupPartial(
        bool? homeassistant = null,
        object? addons = null,
        object? folders = null,
        string? name = null,
        string? password = null,
        bool? compressed = null) {
        _haContext.CallService("hassio", "backup_partial", target: null,
            new HassioBackupPartialParameters {
                Homeassistant = homeassistant, Addons = addons, Folders = folders, Name = name, Password = password,
                Compressed = compressed,
            });
    }

    ///<summary>Reboot the host system.</summary>
    public void HostReboot() {
        _haContext.CallService("hassio", "host_reboot");
    }

    ///<summary>Poweroff the host system.</summary>
    public void HostShutdown() {
        _haContext.CallService("hassio", "host_shutdown");
    }

    ///<summary>Restore from full backup.</summary>
    public void RestoreFull(HassioRestoreFullParameters data) {
        _haContext.CallService("hassio", "restore_full", target: null, data);
    }

    ///<summary>Restore from full backup.</summary>
    ///<param name="slug">Slug of backup to restore from.</param>
    ///<param name="password">Optional password. eg: password</param>
    public void RestoreFull(string slug, string? password = null) {
        _haContext.CallService("hassio", "restore_full", target: null,
            new HassioRestoreFullParameters { Slug = slug, Password = password });
    }

    ///<summary>Restore from partial backup.</summary>
    public void RestorePartial(HassioRestorePartialParameters data) {
        _haContext.CallService("hassio", "restore_partial", target: null, data);
    }

    ///<summary>Restore from partial backup.</summary>
    ///<param name="slug">Slug of backup to restore from.</param>
    ///<param name="homeassistant">Restore Home Assistant</param>
    ///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
    ///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
    ///<param name="password">Optional password. eg: password</param>
    public void RestorePartial(
        string slug,
        bool? homeassistant = null,
        object? folders = null,
        object? addons = null,
        string? password = null) {
        _haContext.CallService("hassio", "restore_partial", target: null,
            new HassioRestorePartialParameters { Slug = slug, Homeassistant = homeassistant, Folders = folders, Addons = addons, Password = password });
    }
}

public record HassioAddonRestartParameters {
    ///<summary>The add-on slug. eg: core_ssh</summary>
    [JsonPropertyName("addon")]
    public string? Addon { get; init; }
}

public record HassioAddonStartParameters {
    ///<summary>The add-on slug. eg: core_ssh</summary>
    [JsonPropertyName("addon")]
    public string? Addon { get; init; }
}

public record HassioAddonStdinParameters {
    ///<summary>The add-on slug. eg: core_ssh</summary>
    [JsonPropertyName("addon")]
    public string? Addon { get; init; }
}

public record HassioAddonStopParameters {
    ///<summary>The add-on slug. eg: core_ssh</summary>
    [JsonPropertyName("addon")]
    public string? Addon { get; init; }
}

public record HassioAddonUpdateParameters {
    ///<summary>The add-on slug. eg: core_ssh</summary>
    [JsonPropertyName("addon")]
    public string? Addon { get; init; }
}

public record HassioBackupFullParameters {
    ///<summary>Optional (default = current date and time). eg: Backup 1</summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    ///<summary>Optional password. eg: password</summary>
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    ///<summary>Use compressed archives</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; init; }
}

public record HassioBackupPartialParameters {
    ///<summary>Backup Home Assistant settings</summary>
    [JsonPropertyName("homeassistant")]
    public bool? Homeassistant { get; init; }

    ///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
    [JsonPropertyName("addons")]
    public object? Addons { get; init; }

    ///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
    [JsonPropertyName("folders")]
    public object? Folders { get; init; }

    ///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    ///<summary>Optional password. eg: password</summary>
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    ///<summary>Use compressed archives</summary>
    [JsonPropertyName("compressed")]
    public bool? Compressed { get; init; }
}

public record HassioRestoreFullParameters {
    ///<summary>Slug of backup to restore from.</summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; init; }

    ///<summary>Optional password. eg: password</summary>
    [JsonPropertyName("password")]
    public string? Password { get; init; }
}

public record HassioRestorePartialParameters {
    ///<summary>Slug of backup to restore from.</summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; init; }

    ///<summary>Restore Home Assistant</summary>
    [JsonPropertyName("homeassistant")]
    public bool? Homeassistant { get; init; }

    ///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
    [JsonPropertyName("folders")]
    public object? Folders { get; init; }

    ///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
    [JsonPropertyName("addons")]
    public object? Addons { get; init; }

    ///<summary>Optional password. eg: password</summary>
    [JsonPropertyName("password")]
    public string? Password { get; init; }
}

public class HomeassistantServices {
    private readonly IHaContext _haContext;

    public HomeassistantServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
    public void CheckConfig() {
        _haContext.CallService("homeassistant", "check_config");
    }

    ///<summary>Reload a config entry that matches a target.</summary>
    ///<param name="target">The target for this service call</param>
    public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data) {
        _haContext.CallService("homeassistant", "reload_config_entry", target, data);
    }

    ///<summary>Reload a config entry that matches a target.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
    public void ReloadConfigEntry(ServiceTarget target, string? entryId = null) {
        _haContext.CallService("homeassistant", "reload_config_entry", target,
            new HomeassistantReloadConfigEntryParameters { EntryId = entryId });
    }

    ///<summary>Reload the core configuration.</summary>
    public void ReloadCoreConfig() {
        _haContext.CallService("homeassistant", "reload_core_config");
    }

    ///<summary>Restart the Home Assistant service.</summary>
    public void Restart() {
        _haContext.CallService("homeassistant", "restart");
    }

    /// <summary>
    ///     Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic
    ///     saving interval.
    /// </summary>
    public void SavePersistentStates() {
        _haContext.CallService("homeassistant", "save_persistent_states");
    }

    ///<summary>Update the Home Assistant location.</summary>
    public void SetLocation(HomeassistantSetLocationParameters data) {
        _haContext.CallService("homeassistant", "set_location", target: null, data);
    }

    ///<summary>Update the Home Assistant location.</summary>
    ///<param name="latitude">Latitude of your location. eg: 32,87336</param>
    ///<param name="longitude">Longitude of your location. eg: 117,22743</param>
    public void SetLocation(string latitude, string longitude) {
        _haContext.CallService("homeassistant", "set_location", target: null,
            new HomeassistantSetLocationParameters { Latitude = latitude, Longitude = longitude });
    }

    ///<summary>Stop the Home Assistant service.</summary>
    public void Stop() {
        _haContext.CallService("homeassistant", "stop");
    }

    ///<summary>Generic service to toggle devices on/off under any domain</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target) {
        _haContext.CallService("homeassistant", "toggle", target);
    }

    ///<summary>Generic service to turn devices off under any domain.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target) {
        _haContext.CallService("homeassistant", "turn_off", target);
    }

    ///<summary>Generic service to turn devices on under any domain.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target) {
        _haContext.CallService("homeassistant", "turn_on", target);
    }

    ///<summary>Force one or more entities to update its data</summary>
    ///<param name="target">The target for this service call</param>
    public void UpdateEntity(ServiceTarget target) {
        _haContext.CallService("homeassistant", "update_entity", target);
    }
}

public record HomeassistantReloadConfigEntryParameters {
    ///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
    [JsonPropertyName("entry_id")]
    public string? EntryId { get; init; }
}

public record HomeassistantSetLocationParameters {
    ///<summary>Latitude of your location. eg: 32,87336</summary>
    [JsonPropertyName("latitude")]
    public string? Latitude { get; init; }

    ///<summary>Longitude of your location. eg: 117,22743</summary>
    [JsonPropertyName("longitude")]
    public string? Longitude { get; init; }
}

public class InputBooleanServices {
    private readonly IHaContext _haContext;

    public InputBooleanServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload the input_boolean configuration</summary>
    public void Reload() {
        _haContext.CallService("input_boolean", "reload");
    }

    ///<summary>Toggle an input boolean</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target) {
        _haContext.CallService("input_boolean", "toggle", target);
    }

    ///<summary>Turn off an input boolean</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target) {
        _haContext.CallService("input_boolean", "turn_off", target);
    }

    ///<summary>Turn on an input boolean</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target) {
        _haContext.CallService("input_boolean", "turn_on", target);
    }
}

public class InputButtonServices {
    private readonly IHaContext _haContext;

    public InputButtonServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Press the input button entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void Press(ServiceTarget target) {
        _haContext.CallService("input_button", "press", target);
    }

    public void Reload() {
        _haContext.CallService("input_button", "reload");
    }
}

public class InputDatetimeServices {
    private readonly IHaContext _haContext;

    public InputDatetimeServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload the input_datetime configuration.</summary>
    public void Reload() {
        _haContext.CallService("input_datetime", "reload");
    }

    ///<summary>This can be used to dynamically set the date and/or time.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data) {
        _haContext.CallService("input_datetime", "set_datetime", target, data);
    }

    ///<summary>This can be used to dynamically set the date and/or time.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
    ///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
    ///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
    ///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
    public void SetDatetime(
        ServiceTarget target,
        string? date = null,
        DateTime? time = null,
        string? datetime = null,
        long? timestamp = null) {
        _haContext.CallService("input_datetime", "set_datetime", target,
            new InputDatetimeSetDatetimeParameters { Date = date, Time = time, Datetime = datetime, Timestamp = timestamp });
    }
}

public record InputDatetimeSetDatetimeParameters {
    ///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
    [JsonPropertyName("date")]
    public string? Date { get; init; }

    ///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
    [JsonPropertyName("time")]
    public DateTime? Time { get; init; }

    ///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
    [JsonPropertyName("datetime")]
    public string? Datetime { get; init; }

    ///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
    [JsonPropertyName("timestamp")]
    public long? Timestamp { get; init; }
}

public class InputNumberServices {
    private readonly IHaContext _haContext;

    public InputNumberServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Decrement the value of an input number entity by its stepping.</summary>
    ///<param name="target">The target for this service call</param>
    public void Decrement(ServiceTarget target) {
        _haContext.CallService("input_number", "decrement", target);
    }

    ///<summary>Increment the value of an input number entity by its stepping.</summary>
    ///<param name="target">The target for this service call</param>
    public void Increment(ServiceTarget target) {
        _haContext.CallService("input_number", "increment", target);
    }

    ///<summary>Reload the input_number configuration.</summary>
    public void Reload() {
        _haContext.CallService("input_number", "reload");
    }

    ///<summary>Set the value of an input number entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetValue(ServiceTarget target, InputNumberSetValueParameters data) {
        _haContext.CallService("input_number", "set_value", target, data);
    }

    ///<summary>Set the value of an input number entity.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="value">The target value the entity should be set to.</param>
    public void SetValue(ServiceTarget target, double value) {
        _haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters { Value = value });
    }
}

public record InputNumberSetValueParameters {
    ///<summary>The target value the entity should be set to.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; init; }
}

public class InputSelectServices {
    private readonly IHaContext _haContext;

    public InputSelectServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload the input_select configuration.</summary>
    public void Reload() {
        _haContext.CallService("input_select", "reload");
    }

    ///<summary>Select the first option of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SelectFirst(ServiceTarget target) {
        _haContext.CallService("input_select", "select_first", target);
    }

    ///<summary>Select the last option of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SelectLast(ServiceTarget target) {
        _haContext.CallService("input_select", "select_last", target);
    }

    ///<summary>Select the next options of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data) {
        _haContext.CallService("input_select", "select_next", target, data);
    }

    ///<summary>Select the next options of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="cycle">If the option should cycle from the last to the first.</param>
    public void SelectNext(ServiceTarget target, bool? cycle = null) {
        _haContext.CallService("input_select", "select_next", target,
            new InputSelectSelectNextParameters { Cycle = cycle });
    }

    ///<summary>Select an option of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data) {
        _haContext.CallService("input_select", "select_option", target, data);
    }

    ///<summary>Select an option of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="option">Option to be selected. eg: "Item A"</param>
    public void SelectOption(ServiceTarget target, string option) {
        _haContext.CallService("input_select", "select_option", target,
            new InputSelectSelectOptionParameters { Option = option });
    }

    ///<summary>Select the previous options of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data) {
        _haContext.CallService("input_select", "select_previous", target, data);
    }

    ///<summary>Select the previous options of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="cycle">If the option should cycle from the first to the last.</param>
    public void SelectPrevious(ServiceTarget target, bool? cycle = null) {
        _haContext.CallService("input_select", "select_previous", target,
            new InputSelectSelectPreviousParameters { Cycle = cycle });
    }

    ///<summary>Set the options of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data) {
        _haContext.CallService("input_select", "set_options", target, data);
    }

    ///<summary>Set the options of an input select entity.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
    public void SetOptions(ServiceTarget target, object options) {
        _haContext.CallService("input_select", "set_options", target,
            new InputSelectSetOptionsParameters { Options = options });
    }
}

public record InputSelectSelectNextParameters {
    ///<summary>If the option should cycle from the last to the first.</summary>
    [JsonPropertyName("cycle")]
    public bool? Cycle { get; init; }
}

public record InputSelectSelectOptionParameters {
    ///<summary>Option to be selected. eg: "Item A"</summary>
    [JsonPropertyName("option")]
    public string? Option { get; init; }
}

public record InputSelectSelectPreviousParameters {
    ///<summary>If the option should cycle from the first to the last.</summary>
    [JsonPropertyName("cycle")]
    public bool? Cycle { get; init; }
}

public record InputSelectSetOptionsParameters {
    ///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
    [JsonPropertyName("options")]
    public object? Options { get; init; }
}

public class InputTextServices {
    private readonly IHaContext _haContext;

    public InputTextServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload the input_text configuration.</summary>
    public void Reload() {
        _haContext.CallService("input_text", "reload");
    }

    ///<summary>Set the value of an input text entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetValue(ServiceTarget target, InputTextSetValueParameters data) {
        _haContext.CallService("input_text", "set_value", target, data);
    }

    ///<summary>Set the value of an input text entity.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
    public void SetValue(ServiceTarget target, string value) {
        _haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters { Value = value });
    }
}

public record InputTextSetValueParameters {
    ///<summary>The target value the entity should be set to. eg: This is an example text</summary>
    [JsonPropertyName("value")]
    public string? Value { get; init; }
}

public class LightServices {
    private readonly IHaContext _haContext;

    public LightServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target, LightToggleParameters data) {
        _haContext.CallService("light", "toggle", target, data);
    }

    /// <summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
    /// <param name="target">The target for this service call</param>
    /// <param name="transition">Duration it takes to get to next state.</param>
    /// <param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
    /// <param name="colorName">A human readable color name.</param>
    /// <param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
    /// <param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
    /// <param name="colorTemp">Color temperature for the light in mireds.</param>
    /// <param name="kelvin">Color temperature for the light in Kelvin.</param>
    /// <param name="whiteValue">Number indicating level of white.</param>
    /// <param name="brightness">
    ///     Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255
    ///     is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessPct">
    ///     Number indicating percentage of full brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 100 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="profile">Name of a light profile to use. eg: relax</param>
    /// <param name="flash">If the light should flash.</param>
    /// <param name="effect">Light effect.</param>
    public void Toggle(
        ServiceTarget target,
        long? transition = null,
        object? rgbColor = null,
        object? colorName = null,
        object? hsColor = null,
        object? xyColor = null,
        object? colorTemp = null,
        long? kelvin = null,
        long? whiteValue = null,
        long? brightness = null,
        long? brightnessPct = null,
        string? profile = null,
        object? flash = null,
        string? effect = null) {
        _haContext.CallService("light", "toggle", target,
            new LightToggleParameters {
                Transition = transition, RgbColor = rgbColor, ColorName = colorName, HsColor = hsColor,
                XyColor = xyColor, ColorTemp = colorTemp, Kelvin = kelvin, WhiteValue = whiteValue,
                Brightness = brightness, BrightnessPct = brightnessPct, Profile = profile, Flash = flash,
                Effect = effect,
            });
    }

    ///<summary>Turns off one or more lights.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target, LightTurnOffParameters data) {
        _haContext.CallService("light", "turn_off", target, data);
    }

    ///<summary>Turns off one or more lights.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="transition">Duration it takes to get to next state.</param>
    ///<param name="flash">If the light should flash.</param>
    public void TurnOff(ServiceTarget target, long? transition = null, object? flash = null) {
        _haContext.CallService("light", "turn_off", target,
            new LightTurnOffParameters { Transition = transition, Flash = flash });
    }

    ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target, LightTurnOnParameters data) {
        _haContext.CallService("light", "turn_on", target, data);
    }

    /// <summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
    /// <param name="target">The target for this service call</param>
    /// <param name="transition">Duration it takes to get to next state.</param>
    /// <param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
    /// <param name="rgbwColor">
    ///     A list containing four integers between 0 and 255 representing the RGBW (red, green, blue,
    ///     white) color for the light. eg: [255, 100, 100, 50]
    /// </param>
    /// <param name="rgbwwColor">
    ///     A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue,
    ///     cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]
    /// </param>
    /// <param name="colorName">A human readable color name.</param>
    /// <param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
    /// <param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
    /// <param name="colorTemp">Color temperature for the light in mireds.</param>
    /// <param name="kelvin">Color temperature for the light in Kelvin.</param>
    /// <param name="brightness">
    ///     Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255
    ///     is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessPct">
    ///     Number indicating percentage of full brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 100 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessStep">Change brightness by an amount.</param>
    /// <param name="brightnessStepPct">Change brightness by a percentage.</param>
    /// <param name="white">
    ///     Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 255 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="profile">Name of a light profile to use. eg: relax</param>
    /// <param name="flash">If the light should flash.</param>
    /// <param name="effect">Light effect.</param>
    public void TurnOn(
        ServiceTarget target,
        long? transition = null,
        object? rgbColor = null,
        object? rgbwColor = null,
        object? rgbwwColor = null,
        object? colorName = null,
        object? hsColor = null,
        object? xyColor = null,
        object? colorTemp = null,
        long? kelvin = null,
        long? brightness = null,
        long? brightnessPct = null,
        long? brightnessStep = null,
        long? brightnessStepPct = null,
        long? white = null,
        string? profile = null,
        object? flash = null,
        string? effect = null) {
        _haContext.CallService("light", "turn_on", target,
            new LightTurnOnParameters {
                Transition = transition, RgbColor = rgbColor, RgbwColor = rgbwColor, RgbwwColor = rgbwwColor,
                ColorName = colorName, HsColor = hsColor, XyColor = xyColor, ColorTemp = colorTemp, Kelvin = kelvin,
                Brightness = brightness, BrightnessPct = brightnessPct, BrightnessStep = brightnessStep,
                BrightnessStepPct = brightnessStepPct, White = white, Profile = profile, Flash = flash, Effect = effect,
            });
    }
}

public record LightToggleParameters {
    ///<summary>Duration it takes to get to next state.</summary>
    [JsonPropertyName("transition")]
    public long? Transition { get; init; }

    ///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
    [JsonPropertyName("rgb_color")]
    public object? RgbColor { get; init; }

    ///<summary>A human readable color name.</summary>
    [JsonPropertyName("color_name")]
    public object? ColorName { get; init; }

    ///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
    [JsonPropertyName("hs_color")]
    public object? HsColor { get; init; }

    ///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
    [JsonPropertyName("xy_color")]
    public object? XyColor { get; init; }

    ///<summary>Color temperature for the light in mireds.</summary>
    [JsonPropertyName("color_temp")]
    public object? ColorTemp { get; init; }

    ///<summary>Color temperature for the light in Kelvin.</summary>
    [JsonPropertyName("kelvin")]
    public long? Kelvin { get; init; }

    ///<summary>Number indicating level of white.</summary>
    [JsonPropertyName("white_value")]
    public long? WhiteValue { get; init; }

    /// <summary>
    ///     Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum
    ///     brightness supported by the light.
    /// </summary>
    [JsonPropertyName("brightness")]
    public long? Brightness { get; init; }

    /// <summary>
    ///     Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and
    ///     100 is the maximum brightness supported by the light.
    /// </summary>
    [JsonPropertyName("brightness_pct")]
    public long? BrightnessPct { get; init; }

    ///<summary>Name of a light profile to use. eg: relax</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; init; }

    ///<summary>If the light should flash.</summary>
    [JsonPropertyName("flash")]
    public object? Flash { get; init; }

    ///<summary>Light effect.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; init; }
}

public record LightTurnOffParameters {
    ///<summary>Duration it takes to get to next state.</summary>
    [JsonPropertyName("transition")]
    public long? Transition { get; init; }

    ///<summary>If the light should flash.</summary>
    [JsonPropertyName("flash")]
    public object? Flash { get; init; }
}

public record LightTurnOnParameters {
    ///<summary>Duration it takes to get to next state.</summary>
    [JsonPropertyName("transition")]
    public long? Transition { get; init; }

    ///<summary>The color for the light (based on RGB - red, green, blue).</summary>
    [JsonPropertyName("rgb_color")]
    public object? RgbColor { get; init; }

    /// <summary>
    ///     A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for
    ///     the light. eg: [255, 100, 100, 50]
    /// </summary>
    [JsonPropertyName("rgbw_color")]
    public object? RgbwColor { get; init; }

    /// <summary>
    ///     A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm
    ///     white) color for the light. eg: [255, 100, 100, 50, 70]
    /// </summary>
    [JsonPropertyName("rgbww_color")]
    public object? RgbwwColor { get; init; }

    ///<summary>A human readable color name.</summary>
    [JsonPropertyName("color_name")]
    public object? ColorName { get; init; }

    ///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
    [JsonPropertyName("hs_color")]
    public object? HsColor { get; init; }

    ///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
    [JsonPropertyName("xy_color")]
    public object? XyColor { get; init; }

    ///<summary>Color temperature for the light in mireds.</summary>
    [JsonPropertyName("color_temp")]
    public object? ColorTemp { get; init; }

    ///<summary>Color temperature for the light in Kelvin.</summary>
    [JsonPropertyName("kelvin")]
    public long? Kelvin { get; init; }

    /// <summary>
    ///     Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum
    ///     brightness supported by the light.
    /// </summary>
    [JsonPropertyName("brightness")]
    public long? Brightness { get; init; }

    /// <summary>
    ///     Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and
    ///     100 is the maximum brightness supported by the light.
    /// </summary>
    [JsonPropertyName("brightness_pct")]
    public long? BrightnessPct { get; init; }

    ///<summary>Change brightness by an amount.</summary>
    [JsonPropertyName("brightness_step")]
    public long? BrightnessStep { get; init; }

    ///<summary>Change brightness by a percentage.</summary>
    [JsonPropertyName("brightness_step_pct")]
    public long? BrightnessStepPct { get; init; }

    /// <summary>
    ///     Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum
    ///     brightness and 255 is the maximum brightness supported by the light.
    /// </summary>
    [JsonPropertyName("white")]
    public long? White { get; init; }

    ///<summary>Name of a light profile to use. eg: relax</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; init; }

    ///<summary>If the light should flash.</summary>
    [JsonPropertyName("flash")]
    public object? Flash { get; init; }

    ///<summary>Light effect.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; init; }
}

public class LockServices {
    private readonly IHaContext _haContext;

    public LockServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Lock all or specified locks.</summary>
    ///<param name="target">The target for this service call</param>
    public void Lock(ServiceTarget target, LockLockParameters data) {
        _haContext.CallService("lock", "lock", target, data);
    }

    ///<summary>Lock all or specified locks.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to lock the lock with. eg: 1234</param>
    public void Lock(ServiceTarget target, string? code = null) {
        _haContext.CallService("lock", "lock", target, new LockLockParameters { Code = code });
    }

    ///<summary>Open all or specified locks.</summary>
    ///<param name="target">The target for this service call</param>
    public void Open(ServiceTarget target, LockOpenParameters data) {
        _haContext.CallService("lock", "open", target, data);
    }

    ///<summary>Open all or specified locks.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to open the lock with. eg: 1234</param>
    public void Open(ServiceTarget target, string? code = null) {
        _haContext.CallService("lock", "open", target, new LockOpenParameters { Code = code });
    }

    ///<summary>Unlock all or specified locks.</summary>
    ///<param name="target">The target for this service call</param>
    public void Unlock(ServiceTarget target, LockUnlockParameters data) {
        _haContext.CallService("lock", "unlock", target, data);
    }

    ///<summary>Unlock all or specified locks.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
    public void Unlock(ServiceTarget target, string? code = null) {
        _haContext.CallService("lock", "unlock", target, new LockUnlockParameters { Code = code });
    }
}

public record LockLockParameters {
    ///<summary>An optional code to lock the lock with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public record LockOpenParameters {
    ///<summary>An optional code to open the lock with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public record LockUnlockParameters {
    ///<summary>An optional code to unlock the lock with. eg: 1234</summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }
}

public class LogbookServices {
    private readonly IHaContext _haContext;

    public LogbookServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Create a custom entry in your logbook.</summary>
    public void Log(LogbookLogParameters data) {
        _haContext.CallService("logbook", "log", target: null, data);
    }

    ///<summary>Create a custom entry in your logbook.</summary>
    ///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
    ///<param name="message">Message of the custom logbook entry. eg: is being used</param>
    ///<param name="entityId">Entity to reference in custom logbook entry.</param>
    ///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
    public void Log(string name, string message, string? entityId = null, string? domain = null) {
        _haContext.CallService("logbook", "log", target: null,
            new LogbookLogParameters { Name = name, Message = message, EntityId = entityId, Domain = domain });
    }
}

public record LogbookLogParameters {
    ///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    ///<summary>Message of the custom logbook entry. eg: is being used</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Entity to reference in custom logbook entry.</summary>
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }

    ///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; init; }
}

public class LovelaceServices {
    private readonly IHaContext _haContext;

    public LovelaceServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload Lovelace resources from YAML configuration</summary>
    public void ReloadResources() {
        _haContext.CallService("lovelace", "reload_resources");
    }
}

public class NotifyServices {
    private readonly IHaContext _haContext;

    public NotifyServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Sends a notification message using the mobile_app_dn2103 integration.</summary>
    public void MobileAppDn2103(NotifyMobileAppDn2103Parameters data) {
        _haContext.CallService("notify", "mobile_app_dn2103", target: null, data);
    }

    /// <summary>Sends a notification message using the mobile_app_dn2103 integration.</summary>
    /// <param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
    /// <param name="title">Title for your notification. eg: Your Garage Door Friend</param>
    /// <param name="target">
    ///     An array of targets to send the notification to. Optional depending on the platform. eg: platform
    ///     specific
    /// </param>
    /// <param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
    public void MobileAppDn2103(string message, string? title = null, object? target = null, object? data = null) {
        _haContext.CallService("notify", "mobile_app_dn2103", target: null,
            new NotifyMobileAppDn2103Parameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the mobile_app_le2123 integration.</summary>
    public void MobileAppLe2123(NotifyMobileAppLe2123Parameters data) {
        _haContext.CallService("notify", "mobile_app_le2123", target: null, data);
    }

    /// <summary>Sends a notification message using the mobile_app_le2123 integration.</summary>
    /// <param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
    /// <param name="title">Title for your notification. eg: Your Garage Door Friend</param>
    /// <param name="target">
    ///     An array of targets to send the notification to. Optional depending on the platform. eg: platform
    ///     specific
    /// </param>
    /// <param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
    public void MobileAppLe2123(string message, string? title = null, object? target = null, object? data = null) {
        _haContext.CallService("notify", "mobile_app_le2123", target: null,
            new NotifyMobileAppLe2123Parameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification message using the notify service.</summary>
    public void Notify(NotifyNotifyParameters data) {
        _haContext.CallService("notify", "notify", target: null, data);
    }

    /// <summary>Sends a notification message using the notify service.</summary>
    /// <param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
    /// <param name="title">Title for your notification. eg: Your Garage Door Friend</param>
    /// <param name="target">
    ///     An array of targets to send the notification to. Optional depending on the platform. eg: platform
    ///     specific
    /// </param>
    /// <param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
    public void Notify(string message, string? title = null, object? target = null, object? data = null) {
        _haContext.CallService("notify", "notify", target: null,
            new NotifyNotifyParameters { Message = message, Title = title, Target = target, Data = data });
    }

    ///<summary>Sends a notification that is visible in the front-end.</summary>
    public void PersistentNotification(NotifyPersistentNotificationParameters data) {
        _haContext.CallService("notify", "persistent_notification", target: null, data);
    }

    ///<summary>Sends a notification that is visible in the front-end.</summary>
    ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
    ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
    public void PersistentNotification(string message, string? title = null) {
        _haContext.CallService("notify", "persistent_notification", target: null,
            new NotifyPersistentNotificationParameters { Message = message, Title = title });
    }

    ///<summary>Sends a notification message using the tibber service.</summary>
    public void Tibber(NotifyTibberParameters data) {
        _haContext.CallService("notify", "tibber", target: null, data);
    }

    /// <summary>Sends a notification message using the tibber service.</summary>
    /// <param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
    /// <param name="title">Title for your notification. eg: Your Garage Door Friend</param>
    /// <param name="target">
    ///     An array of targets to send the notification to. Optional depending on the platform. eg: platform
    ///     specific
    /// </param>
    /// <param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
    public void Tibber(string message, string? title = null, object? target = null, object? data = null) {
        _haContext.CallService("notify", "tibber", target: null,
            new NotifyTibberParameters { Message = message, Title = title, Target = target, Data = data });
    }
}

public record NotifyMobileAppDn2103Parameters {
    ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("target")]
    public object? Target { get; init; }

    ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("data")]
    public object? Data { get; init; }
}

public record NotifyMobileAppLe2123Parameters {
    ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("target")]
    public object? Target { get; init; }

    ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("data")]
    public object? Data { get; init; }
}

public record NotifyNotifyParameters {
    ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("target")]
    public object? Target { get; init; }

    ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("data")]
    public object? Data { get; init; }
}

public record NotifyPersistentNotificationParameters {
    ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }
}

public record NotifyTibberParameters {
    ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("target")]
    public object? Target { get; init; }

    ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("data")]
    public object? Data { get; init; }
}

public class NumberServices {
    private readonly IHaContext _haContext;

    public NumberServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Set the value of a Number entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SetValue(ServiceTarget target, NumberSetValueParameters data) {
        _haContext.CallService("number", "set_value", target, data);
    }

    ///<summary>Set the value of a Number entity.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="value">The target value the entity should be set to. eg: 42</param>
    public void SetValue(ServiceTarget target, string? value = null) {
        _haContext.CallService("number", "set_value", target, new NumberSetValueParameters { Value = value });
    }
}

public record NumberSetValueParameters {
    ///<summary>The target value the entity should be set to. eg: 42</summary>
    [JsonPropertyName("value")]
    public string? Value { get; init; }
}

public class PersistentNotificationServices {
    private readonly IHaContext _haContext;

    public PersistentNotificationServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Show a notification in the frontend.</summary>
    public void Create(PersistentNotificationCreateParameters data) {
        _haContext.CallService("persistent_notification", "create", target: null, data);
    }

    ///<summary>Show a notification in the frontend.</summary>
    ///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
    ///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
    ///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
    public void Create(string message, string? title = null, string? notificationId = null) {
        _haContext.CallService("persistent_notification", "create", target: null,
            new PersistentNotificationCreateParameters { Message = message, Title = title, NotificationId = notificationId });
    }

    ///<summary>Remove a notification from the frontend.</summary>
    public void Dismiss(PersistentNotificationDismissParameters data) {
        _haContext.CallService("persistent_notification", "dismiss", target: null, data);
    }

    ///<summary>Remove a notification from the frontend.</summary>
    ///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
    public void Dismiss(string notificationId) {
        _haContext.CallService("persistent_notification", "dismiss", target: null,
            new PersistentNotificationDismissParameters { NotificationId = notificationId });
    }

    ///<summary>Mark a notification read.</summary>
    public void MarkRead(PersistentNotificationMarkReadParameters data) {
        _haContext.CallService("persistent_notification", "mark_read", target: null, data);
    }

    ///<summary>Mark a notification read.</summary>
    ///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
    public void MarkRead(string notificationId) {
        _haContext.CallService("persistent_notification", "mark_read", target: null,
            new PersistentNotificationMarkReadParameters { NotificationId = notificationId });
    }
}

public record PersistentNotificationCreateParameters {
    ///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    ///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
    [JsonPropertyName("notification_id")]
    public string? NotificationId { get; init; }
}

public record PersistentNotificationDismissParameters {
    ///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
    [JsonPropertyName("notification_id")]
    public string? NotificationId { get; init; }
}

public record PersistentNotificationMarkReadParameters {
    ///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
    [JsonPropertyName("notification_id")]
    public string? NotificationId { get; init; }
}

public class PersonServices {
    private readonly IHaContext _haContext;

    public PersonServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload the person configuration.</summary>
    public void Reload() {
        _haContext.CallService("person", "reload");
    }
}

public class PythonScriptServices {
    private readonly IHaContext _haContext;

    public PythonScriptServices(IHaContext haContext) {
        _haContext = haContext;
    }

    public void HelloWorld() {
        _haContext.CallService("python_script", "hello_world");
    }

    ///<summary>Reload all available python_scripts</summary>
    public void Reload() {
        _haContext.CallService("python_script", "reload");
    }
}

public class RecorderServices {
    private readonly IHaContext _haContext;

    public RecorderServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Stop the recording of events and state changes</summary>
    public void Disable() {
        _haContext.CallService("recorder", "disable");
    }

    ///<summary>Start the recording of events and state changes</summary>
    public void Enable() {
        _haContext.CallService("recorder", "enable");
    }

    ///<summary>Start purge task - to clean up old data from your database.</summary>
    public void Purge(RecorderPurgeParameters data) {
        _haContext.CallService("recorder", "purge", target: null, data);
    }

    ///<summary>Start purge task - to clean up old data from your database.</summary>
    ///<param name="keepDays">Number of history days to keep in database after purge.</param>
    ///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
    ///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
    public void Purge(long? keepDays = null, bool? repack = null, bool? applyFilter = null) {
        _haContext.CallService("recorder", "purge", target: null,
            new RecorderPurgeParameters { KeepDays = keepDays, Repack = repack, ApplyFilter = applyFilter });
    }

    ///<summary>Start purge task to remove specific entities from your database.</summary>
    ///<param name="target">The target for this service call</param>
    public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data) {
        _haContext.CallService("recorder", "purge_entities", target, data);
    }

    /// <summary>Start purge task to remove specific entities from your database.</summary>
    /// <param name="target">The target for this service call</param>
    /// <param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
    /// <param name="entityGlobs">
    ///     List the glob patterns to select entities for removal from the recorder database. eg:
    ///     domain*.object_id*
    /// </param>
    public void PurgeEntities(ServiceTarget target, object? domains = null, object? entityGlobs = null) {
        _haContext.CallService("recorder", "purge_entities", target,
            new RecorderPurgeEntitiesParameters { Domains = domains, EntityGlobs = entityGlobs });
    }
}

public record RecorderPurgeParameters {
    ///<summary>Number of history days to keep in database after purge.</summary>
    [JsonPropertyName("keep_days")]
    public long? KeepDays { get; init; }

    ///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
    [JsonPropertyName("repack")]
    public bool? Repack { get; init; }

    ///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
    [JsonPropertyName("apply_filter")]
    public bool? ApplyFilter { get; init; }
}

public record RecorderPurgeEntitiesParameters {
    ///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
    [JsonPropertyName("domains")]
    public object? Domains { get; init; }

    ///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
    [JsonPropertyName("entity_globs")]
    public object? EntityGlobs { get; init; }
}

public class SceneServices {
    private readonly IHaContext _haContext;

    public SceneServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Activate a scene with configuration.</summary>
    public void Apply(SceneApplyParameters data) {
        _haContext.CallService("scene", "apply", target: null, data);
    }

    /// <summary>Activate a scene with configuration.</summary>
    /// <param name="entities">
    ///     The entities and the state that they need to be. eg:
    ///     {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}
    /// </param>
    /// <param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
    public void Apply(object entities, long? transition = null) {
        _haContext.CallService("scene", "apply", target: null,
            new SceneApplyParameters { Entities = entities, Transition = transition });
    }

    ///<summary>Creates a new scene.</summary>
    public void Create(SceneCreateParameters data) {
        _haContext.CallService("scene", "create", target: null, data);
    }

    /// <summary>Creates a new scene.</summary>
    /// <param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
    /// <param name="entities">
    ///     The entities to control with the scene. eg:
    ///     {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}
    /// </param>
    /// <param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
    public void Create(string sceneId, object? entities = null, object? snapshotEntities = null) {
        _haContext.CallService("scene", "create", target: null,
            new SceneCreateParameters { SceneId = sceneId, Entities = entities, SnapshotEntities = snapshotEntities });
    }

    ///<summary>Reload the scene configuration.</summary>
    public void Reload() {
        _haContext.CallService("scene", "reload");
    }

    ///<summary>Activate a scene.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target, SceneTurnOnParameters data) {
        _haContext.CallService("scene", "turn_on", target, data);
    }

    ///<summary>Activate a scene.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
    public void TurnOn(ServiceTarget target, long? transition = null) {
        _haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters { Transition = transition });
    }
}

public record SceneApplyParameters {
    /// <summary>
    ///     The entities and the state that they need to be. eg:
    ///     {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}
    /// </summary>
    [JsonPropertyName("entities")]
    public object? Entities { get; init; }

    ///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
    [JsonPropertyName("transition")]
    public long? Transition { get; init; }
}

public record SceneCreateParameters {
    ///<summary>The entity_id of the new scene. eg: all_lights</summary>
    [JsonPropertyName("scene_id")]
    public string? SceneId { get; init; }

    /// <summary>
    ///     The entities to control with the scene. eg:
    ///     {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}
    /// </summary>
    [JsonPropertyName("entities")]
    public object? Entities { get; init; }

    ///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
    [JsonPropertyName("snapshot_entities")]
    public object? SnapshotEntities { get; init; }
}

public record SceneTurnOnParameters {
    ///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
    [JsonPropertyName("transition")]
    public long? Transition { get; init; }
}

public class ScriptServices {
    private readonly IHaContext _haContext;

    public ScriptServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload all the available scripts</summary>
    public void Reload() {
        _haContext.CallService("script", "reload");
    }

    ///<summary>Toggle script</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target) {
        _haContext.CallService("script", "toggle", target);
    }

    ///<summary>Turn off script</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target) {
        _haContext.CallService("script", "turn_off", target);
    }

    ///<summary>Turn on script</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target) {
        _haContext.CallService("script", "turn_on", target);
    }
}

public class SelectServices {
    private readonly IHaContext _haContext;

    public SelectServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Select an option of an select entity.</summary>
    ///<param name="target">The target for this service call</param>
    public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data) {
        _haContext.CallService("select", "select_option", target, data);
    }

    ///<summary>Select an option of an select entity.</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="option">Option to be selected. eg: "Item A"</param>
    public void SelectOption(ServiceTarget target, string option) {
        _haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters { Option = option });
    }
}

public record SelectSelectOptionParameters {
    ///<summary>Option to be selected. eg: "Item A"</summary>
    [JsonPropertyName("option")]
    public string? Option { get; init; }
}

public class SirenServices {
    private readonly IHaContext _haContext;

    public SirenServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Toggles a siren.</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target) {
        _haContext.CallService("siren", "toggle", target);
    }

    ///<summary>Turn siren off.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target) {
        _haContext.CallService("siren", "turn_off", target);
    }

    ///<summary>Turn siren on.</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target, SirenTurnOnParameters data) {
        _haContext.CallService("siren", "turn_on", target, data);
    }

    /// <summary>Turn siren on.</summary>
    /// <param name="target">The target for this service call</param>
    /// <param name="tone">
    ///     The tone to emit when turning the siren on. When `available_tones` property is a map, either the key
    ///     or the value can be used. Must be supported by the integration. eg: fire
    /// </param>
    /// <param name="volumeLevel">
    ///     The volume level of the noise to emit when turning the siren on. Must be supported by the
    ///     integration. eg: 0,5
    /// </param>
    /// <param name="duration">
    ///     The duration in seconds of the noise to emit when turning the siren on. Must be supported by the
    ///     integration. eg: 15
    /// </param>
    public void TurnOn(ServiceTarget target, string? tone = null, double? volumeLevel = null, string? duration = null) {
        _haContext.CallService("siren", "turn_on", target,
            new SirenTurnOnParameters { Tone = tone, VolumeLevel = volumeLevel, Duration = duration });
    }
}

public record SirenTurnOnParameters {
    /// <summary>
    ///     The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the
    ///     value can be used. Must be supported by the integration. eg: fire
    /// </summary>
    [JsonPropertyName("tone")]
    public string? Tone { get; init; }

    ///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</summary>
    [JsonPropertyName("volume_level")]
    public double? VolumeLevel { get; init; }

    /// <summary>
    ///     The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration.
    ///     eg: 15
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; init; }
}

public class SpeedtestdotnetServices {
    private readonly IHaContext _haContext;

    public SpeedtestdotnetServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Immediately execute a speed test with Speedtest.net</summary>
    public void Speedtest() {
        _haContext.CallService("speedtestdotnet", "speedtest");
    }
}

public class SwitchServices {
    private readonly IHaContext _haContext;

    public SwitchServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Toggles a switch state</summary>
    ///<param name="target">The target for this service call</param>
    public void Toggle(ServiceTarget target) {
        _haContext.CallService("switch", "toggle", target);
    }

    ///<summary>Turn a switch off</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOff(ServiceTarget target) {
        _haContext.CallService("switch", "turn_off", target);
    }

    ///<summary>Turn a switch on</summary>
    ///<param name="target">The target for this service call</param>
    public void TurnOn(ServiceTarget target) {
        _haContext.CallService("switch", "turn_on", target);
    }
}

public class SystemLogServices {
    private readonly IHaContext _haContext;

    public SystemLogServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Clear all log entries.</summary>
    public void Clear() {
        _haContext.CallService("system_log", "clear");
    }

    ///<summary>Write log entry.</summary>
    public void Write(SystemLogWriteParameters data) {
        _haContext.CallService("system_log", "write", target: null, data);
    }

    /// <summary>Write log entry.</summary>
    /// <param name="message">Message to log. eg: Something went wrong</param>
    /// <param name="level">Log level.</param>
    /// <param name="logger">
    ///     Logger name under which to log the message. Defaults to 'system_log.external'. eg:
    ///     mycomponent.myplatform
    /// </param>
    public void Write(string message, object? level = null, string? logger = null) {
        _haContext.CallService("system_log", "write", target: null,
            new SystemLogWriteParameters { Message = message, Level = level, Logger = logger });
    }
}

public record SystemLogWriteParameters {
    ///<summary>Message to log. eg: Something went wrong</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Log level.</summary>
    [JsonPropertyName("level")]
    public object? Level { get; init; }

    ///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
    [JsonPropertyName("logger")]
    public string? Logger { get; init; }
}

public class TemplateServices {
    private readonly IHaContext _haContext;

    public TemplateServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload all template entities.</summary>
    public void Reload() {
        _haContext.CallService("template", "reload");
    }
}

public class TimerServices {
    private readonly IHaContext _haContext;

    public TimerServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Cancel a timer.</summary>
    ///<param name="target">The target for this service call</param>
    public void Cancel(ServiceTarget target) {
        _haContext.CallService("timer", "cancel", target);
    }

    ///<summary>Finish a timer.</summary>
    ///<param name="target">The target for this service call</param>
    public void Finish(ServiceTarget target) {
        _haContext.CallService("timer", "finish", target);
    }

    ///<summary>Pause a timer.</summary>
    ///<param name="target">The target for this service call</param>
    public void Pause(ServiceTarget target) {
        _haContext.CallService("timer", "pause", target);
    }

    public void Reload() {
        _haContext.CallService("timer", "reload");
    }

    ///<summary>Start a timer</summary>
    ///<param name="target">The target for this service call</param>
    public void Start(ServiceTarget target, TimerStartParameters data) {
        _haContext.CallService("timer", "start", target, data);
    }

    ///<summary>Start a timer</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
    public void Start(ServiceTarget target, string? duration = null) {
        _haContext.CallService("timer", "start", target, new TimerStartParameters { Duration = duration });
    }
}

public record TimerStartParameters {
    ///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; init; }
}

public class TtsServices {
    private readonly IHaContext _haContext;

    public TtsServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
    public void ClearCache() {
        _haContext.CallService("tts", "clear_cache");
    }

    ///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
    public void GoogleTranslateSay(TtsGoogleTranslateSayParameters data) {
        _haContext.CallService("tts", "google_translate_say", target: null, data);
    }

    /// <summary>Say something using text-to-speech on a media player with google_translate.</summary>
    /// <param name="entityId">Name(s) of media player entities.</param>
    /// <param name="message">Text to speak on devices. eg: My name is hanna</param>
    /// <param name="cache">Control file cache of this message.</param>
    /// <param name="language">Language to use for speech generation. eg: ru</param>
    /// <param name="options">
    ///     A dictionary containing platform-specific options. Optional depending on the platform. eg:
    ///     platform specific
    /// </param>
    public void GoogleTranslateSay(
        string entityId,
        string message,
        bool? cache = null,
        string? language = null,
        object? options = null) {
        _haContext.CallService("tts", "google_translate_say", target: null,
            new TtsGoogleTranslateSayParameters { EntityId = entityId, Message = message, Cache = cache, Language = language, Options = options });
    }
}

public record TtsGoogleTranslateSayParameters {
    ///<summary>Name(s) of media player entities.</summary>
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }

    ///<summary>Text to speak on devices. eg: My name is hanna</summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    ///<summary>Control file cache of this message.</summary>
    [JsonPropertyName("cache")]
    public bool? Cache { get; init; }

    ///<summary>Language to use for speech generation. eg: ru</summary>
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    ///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
    [JsonPropertyName("options")]
    public object? Options { get; init; }
}

public class UpdateServices {
    private readonly IHaContext _haContext;

    public UpdateServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Removes the skipped version marker from an update.</summary>
    ///<param name="target">The target for this service call</param>
    public void ClearSkipped(ServiceTarget target) {
        _haContext.CallService("update", "clear_skipped", target);
    }

    ///<summary>Install an update for this device or service</summary>
    ///<param name="target">The target for this service call</param>
    public void Install(ServiceTarget target, UpdateInstallParameters data) {
        _haContext.CallService("update", "install", target, data);
    }

    ///<summary>Install an update for this device or service</summary>
    ///<param name="target">The target for this service call</param>
    ///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
    ///<param name="backup">Backup before installing the update, if supported by the integration.</param>
    public void Install(ServiceTarget target, string? version = null, bool? backup = null) {
        _haContext.CallService("update", "install", target,
            new UpdateInstallParameters { Version = version, Backup = backup });
    }

    ///<summary>Mark currently available update as skipped.</summary>
    ///<param name="target">The target for this service call</param>
    public void Skip(ServiceTarget target) {
        _haContext.CallService("update", "skip", target);
    }
}

public record UpdateInstallParameters {
    ///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    ///<summary>Backup before installing the update, if supported by the integration.</summary>
    [JsonPropertyName("backup")]
    public bool? Backup { get; init; }
}

public class ZoneServices {
    private readonly IHaContext _haContext;

    public ZoneServices(IHaContext haContext) {
        _haContext = haContext;
    }

    ///<summary>Reload the YAML-based zone configuration.</summary>
    public void Reload() {
        _haContext.CallService("zone", "reload");
    }
}

public static class AutomationEntityExtensionMethods {
    ///<summary>Toggle (enable / disable) an automation.</summary>
    public static void Toggle(this AutomationEntity target) {
        target.CallService("toggle");
    }

    ///<summary>Toggle (enable / disable) an automation.</summary>
    public static void Toggle(this IEnumerable<AutomationEntity> target) {
        target.CallService("toggle");
    }

    ///<summary>Trigger the actions of an automation.</summary>
    public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data) {
        target.CallService("trigger", data);
    }

    ///<summary>Trigger the actions of an automation.</summary>
    public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data) {
        target.CallService("trigger", data);
    }

    ///<summary>Trigger the actions of an automation.</summary>
    ///<param name="target">The AutomationEntity to call this service for</param>
    ///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
    public static void Trigger(this AutomationEntity target, bool? skipCondition = null) {
        target.CallService("trigger", new AutomationTriggerParameters { SkipCondition = skipCondition });
    }

    ///<summary>Trigger the actions of an automation.</summary>
    ///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
    ///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
    public static void Trigger(this IEnumerable<AutomationEntity> target, bool? skipCondition = null) {
        target.CallService("trigger", new AutomationTriggerParameters { SkipCondition = skipCondition });
    }

    ///<summary>Disable an automation.</summary>
    public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data) {
        target.CallService("turn_off", data);
    }

    ///<summary>Disable an automation.</summary>
    public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data) {
        target.CallService("turn_off", data);
    }

    ///<summary>Disable an automation.</summary>
    ///<param name="target">The AutomationEntity to call this service for</param>
    ///<param name="stopActions">Stop currently running actions.</param>
    public static void TurnOff(this AutomationEntity target, bool? stopActions = null) {
        target.CallService("turn_off", new AutomationTurnOffParameters { StopActions = stopActions });
    }

    ///<summary>Disable an automation.</summary>
    ///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
    ///<param name="stopActions">Stop currently running actions.</param>
    public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? stopActions = null) {
        target.CallService("turn_off", new AutomationTurnOffParameters { StopActions = stopActions });
    }

    ///<summary>Enable an automation.</summary>
    public static void TurnOn(this AutomationEntity target) {
        target.CallService("turn_on");
    }

    ///<summary>Enable an automation.</summary>
    public static void TurnOn(this IEnumerable<AutomationEntity> target) {
        target.CallService("turn_on");
    }
}

public static class ButtonEntityExtensionMethods {
    ///<summary>Press the button entity.</summary>
    public static void Press(this ButtonEntity target) {
        target.CallService("press");
    }

    ///<summary>Press the button entity.</summary>
    public static void Press(this IEnumerable<ButtonEntity> target) {
        target.CallService("press");
    }
}

public static class CoverEntityExtensionMethods {
    ///<summary>Close all or specified cover.</summary>
    public static void CloseCover(this CoverEntity target) {
        target.CallService("close_cover");
    }

    ///<summary>Close all or specified cover.</summary>
    public static void CloseCover(this IEnumerable<CoverEntity> target) {
        target.CallService("close_cover");
    }

    ///<summary>Close all or specified cover tilt.</summary>
    public static void CloseCoverTilt(this CoverEntity target) {
        target.CallService("close_cover_tilt");
    }

    ///<summary>Close all or specified cover tilt.</summary>
    public static void CloseCoverTilt(this IEnumerable<CoverEntity> target) {
        target.CallService("close_cover_tilt");
    }

    ///<summary>Open all or specified cover.</summary>
    public static void OpenCover(this CoverEntity target) {
        target.CallService("open_cover");
    }

    ///<summary>Open all or specified cover.</summary>
    public static void OpenCover(this IEnumerable<CoverEntity> target) {
        target.CallService("open_cover");
    }

    ///<summary>Open all or specified cover tilt.</summary>
    public static void OpenCoverTilt(this CoverEntity target) {
        target.CallService("open_cover_tilt");
    }

    ///<summary>Open all or specified cover tilt.</summary>
    public static void OpenCoverTilt(this IEnumerable<CoverEntity> target) {
        target.CallService("open_cover_tilt");
    }

    ///<summary>Move to specific position all or specified cover.</summary>
    public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data) {
        target.CallService("set_cover_position", data);
    }

    ///<summary>Move to specific position all or specified cover.</summary>
    public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data) {
        target.CallService("set_cover_position", data);
    }

    ///<summary>Move to specific position all or specified cover.</summary>
    ///<param name="target">The CoverEntity to call this service for</param>
    ///<param name="position">Position of the cover</param>
    public static void SetCoverPosition(this CoverEntity target, long position) {
        target.CallService("set_cover_position", new CoverSetCoverPositionParameters { Position = position });
    }

    ///<summary>Move to specific position all or specified cover.</summary>
    ///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
    ///<param name="position">Position of the cover</param>
    public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long position) {
        target.CallService("set_cover_position", new CoverSetCoverPositionParameters { Position = position });
    }

    ///<summary>Move to specific position all or specified cover tilt.</summary>
    public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data) {
        target.CallService("set_cover_tilt_position", data);
    }

    ///<summary>Move to specific position all or specified cover tilt.</summary>
    public static void SetCoverTiltPosition(
        this IEnumerable<CoverEntity> target,
        CoverSetCoverTiltPositionParameters data) {
        target.CallService("set_cover_tilt_position", data);
    }

    ///<summary>Move to specific position all or specified cover tilt.</summary>
    ///<param name="target">The CoverEntity to call this service for</param>
    ///<param name="tiltPosition">Tilt position of the cover.</param>
    public static void SetCoverTiltPosition(this CoverEntity target, long tiltPosition) {
        target.CallService("set_cover_tilt_position",
            new CoverSetCoverTiltPositionParameters { TiltPosition = tiltPosition });
    }

    ///<summary>Move to specific position all or specified cover tilt.</summary>
    ///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
    ///<param name="tiltPosition">Tilt position of the cover.</param>
    public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long tiltPosition) {
        target.CallService("set_cover_tilt_position",
            new CoverSetCoverTiltPositionParameters { TiltPosition = tiltPosition });
    }

    ///<summary>Stop all or specified cover.</summary>
    public static void StopCover(this CoverEntity target) {
        target.CallService("stop_cover");
    }

    ///<summary>Stop all or specified cover.</summary>
    public static void StopCover(this IEnumerable<CoverEntity> target) {
        target.CallService("stop_cover");
    }

    ///<summary>Stop all or specified cover.</summary>
    public static void StopCoverTilt(this CoverEntity target) {
        target.CallService("stop_cover_tilt");
    }

    ///<summary>Stop all or specified cover.</summary>
    public static void StopCoverTilt(this IEnumerable<CoverEntity> target) {
        target.CallService("stop_cover_tilt");
    }

    ///<summary>Toggle a cover open/closed.</summary>
    public static void Toggle(this CoverEntity target) {
        target.CallService("toggle");
    }

    ///<summary>Toggle a cover open/closed.</summary>
    public static void Toggle(this IEnumerable<CoverEntity> target) {
        target.CallService("toggle");
    }

    ///<summary>Toggle a cover tilt open/closed.</summary>
    public static void ToggleCoverTilt(this CoverEntity target) {
        target.CallService("toggle_cover_tilt");
    }

    ///<summary>Toggle a cover tilt open/closed.</summary>
    public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target) {
        target.CallService("toggle_cover_tilt");
    }
}

public static class InputBooleanEntityExtensionMethods {
    ///<summary>Toggle an input boolean</summary>
    public static void Toggle(this InputBooleanEntity target) {
        target.CallService("toggle");
    }

    ///<summary>Toggle an input boolean</summary>
    public static void Toggle(this IEnumerable<InputBooleanEntity> target) {
        target.CallService("toggle");
    }

    ///<summary>Turn off an input boolean</summary>
    public static void TurnOff(this InputBooleanEntity target) {
        target.CallService("turn_off");
    }

    ///<summary>Turn off an input boolean</summary>
    public static void TurnOff(this IEnumerable<InputBooleanEntity> target) {
        target.CallService("turn_off");
    }

    ///<summary>Turn on an input boolean</summary>
    public static void TurnOn(this InputBooleanEntity target) {
        target.CallService("turn_on");
    }

    ///<summary>Turn on an input boolean</summary>
    public static void TurnOn(this IEnumerable<InputBooleanEntity> target) {
        target.CallService("turn_on");
    }
}

public static class InputNumberEntityExtensionMethods {
    ///<summary>Decrement the value of an input number entity by its stepping.</summary>
    public static void Decrement(this InputNumberEntity target) {
        target.CallService("decrement");
    }

    ///<summary>Decrement the value of an input number entity by its stepping.</summary>
    public static void Decrement(this IEnumerable<InputNumberEntity> target) {
        target.CallService("decrement");
    }

    ///<summary>Increment the value of an input number entity by its stepping.</summary>
    public static void Increment(this InputNumberEntity target) {
        target.CallService("increment");
    }

    ///<summary>Increment the value of an input number entity by its stepping.</summary>
    public static void Increment(this IEnumerable<InputNumberEntity> target) {
        target.CallService("increment");
    }

    ///<summary>Set the value of an input number entity.</summary>
    public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data) {
        target.CallService("set_value", data);
    }

    ///<summary>Set the value of an input number entity.</summary>
    public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data) {
        target.CallService("set_value", data);
    }

    ///<summary>Set the value of an input number entity.</summary>
    ///<param name="target">The InputNumberEntity to call this service for</param>
    ///<param name="value">The target value the entity should be set to.</param>
    public static void SetValue(this InputNumberEntity target, double value) {
        target.CallService("set_value", new InputNumberSetValueParameters { Value = value });
    }

    ///<summary>Set the value of an input number entity.</summary>
    ///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
    ///<param name="value">The target value the entity should be set to.</param>
    public static void SetValue(this IEnumerable<InputNumberEntity> target, double value) {
        target.CallService("set_value", new InputNumberSetValueParameters { Value = value });
    }
}

public static class LightEntityExtensionMethods {
    ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
    public static void Toggle(this LightEntity target, LightToggleParameters data) {
        target.CallService("toggle", data);
    }

    ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
    public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data) {
        target.CallService("toggle", data);
    }

    /// <summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
    /// <param name="target">The LightEntity to call this service for</param>
    /// <param name="transition">Duration it takes to get to next state.</param>
    /// <param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
    /// <param name="colorName">A human readable color name.</param>
    /// <param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
    /// <param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
    /// <param name="colorTemp">Color temperature for the light in mireds.</param>
    /// <param name="kelvin">Color temperature for the light in Kelvin.</param>
    /// <param name="whiteValue">Number indicating level of white.</param>
    /// <param name="brightness">
    ///     Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255
    ///     is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessPct">
    ///     Number indicating percentage of full brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 100 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="profile">Name of a light profile to use. eg: relax</param>
    /// <param name="flash">If the light should flash.</param>
    /// <param name="effect">Light effect.</param>
    public static void Toggle(
        this LightEntity target,
        long? transition = null,
        object? rgbColor = null,
        object? colorName = null,
        object? hsColor = null,
        object? xyColor = null,
        object? colorTemp = null,
        long? kelvin = null,
        long? whiteValue = null,
        long? brightness = null,
        long? brightnessPct = null,
        string? profile = null,
        object? flash = null,
        string? effect = null) {
        target.CallService("toggle",
            new LightToggleParameters {
                Transition = transition, RgbColor = rgbColor, ColorName = colorName, HsColor = hsColor,
                XyColor = xyColor, ColorTemp = colorTemp, Kelvin = kelvin, WhiteValue = whiteValue,
                Brightness = brightness, BrightnessPct = brightnessPct, Profile = profile, Flash = flash,
                Effect = effect,
            });
    }

    /// <summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
    /// <param name="target">The IEnumerable<LightEntity> to call this service for</param>
    /// <param name="transition">Duration it takes to get to next state.</param>
    /// <param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
    /// <param name="colorName">A human readable color name.</param>
    /// <param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
    /// <param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
    /// <param name="colorTemp">Color temperature for the light in mireds.</param>
    /// <param name="kelvin">Color temperature for the light in Kelvin.</param>
    /// <param name="whiteValue">Number indicating level of white.</param>
    /// <param name="brightness">
    ///     Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255
    ///     is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessPct">
    ///     Number indicating percentage of full brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 100 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="profile">Name of a light profile to use. eg: relax</param>
    /// <param name="flash">If the light should flash.</param>
    /// <param name="effect">Light effect.</param>
    public static void Toggle(
        this IEnumerable<LightEntity> target,
        long? transition = null,
        object? rgbColor = null,
        object? colorName = null,
        object? hsColor = null,
        object? xyColor = null,
        object? colorTemp = null,
        long? kelvin = null,
        long? whiteValue = null,
        long? brightness = null,
        long? brightnessPct = null,
        string? profile = null,
        object? flash = null,
        string? effect = null) {
        target.CallService("toggle",
            new LightToggleParameters {
                Transition = transition, RgbColor = rgbColor, ColorName = colorName, HsColor = hsColor,
                XyColor = xyColor, ColorTemp = colorTemp, Kelvin = kelvin, WhiteValue = whiteValue,
                Brightness = brightness, BrightnessPct = brightnessPct, Profile = profile, Flash = flash,
                Effect = effect,
            });
    }

    ///<summary>Turns off one or more lights.</summary>
    public static void TurnOff(this LightEntity target, LightTurnOffParameters data) {
        target.CallService("turn_off", data);
    }

    ///<summary>Turns off one or more lights.</summary>
    public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data) {
        target.CallService("turn_off", data);
    }

    ///<summary>Turns off one or more lights.</summary>
    ///<param name="target">The LightEntity to call this service for</param>
    ///<param name="transition">Duration it takes to get to next state.</param>
    ///<param name="flash">If the light should flash.</param>
    public static void TurnOff(this LightEntity target, long? transition = null, object? flash = null) {
        target.CallService("turn_off", new LightTurnOffParameters { Transition = transition, Flash = flash });
    }

    ///<summary>Turns off one or more lights.</summary>
    ///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
    ///<param name="transition">Duration it takes to get to next state.</param>
    ///<param name="flash">If the light should flash.</param>
    public static void TurnOff(this IEnumerable<LightEntity> target, long? transition = null, object? flash = null) {
        target.CallService("turn_off", new LightTurnOffParameters { Transition = transition, Flash = flash });
    }

    ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
    public static void TurnOn(this LightEntity target, LightTurnOnParameters data) {
        target.CallService("turn_on", data);
    }

    ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
    public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data) {
        target.CallService("turn_on", data);
    }

    /// <summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
    /// <param name="target">The LightEntity to call this service for</param>
    /// <param name="transition">Duration it takes to get to next state.</param>
    /// <param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
    /// <param name="rgbwColor">
    ///     A list containing four integers between 0 and 255 representing the RGBW (red, green, blue,
    ///     white) color for the light. eg: [255, 100, 100, 50]
    /// </param>
    /// <param name="rgbwwColor">
    ///     A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue,
    ///     cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]
    /// </param>
    /// <param name="colorName">A human readable color name.</param>
    /// <param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
    /// <param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
    /// <param name="colorTemp">Color temperature for the light in mireds.</param>
    /// <param name="kelvin">Color temperature for the light in Kelvin.</param>
    /// <param name="brightness">
    ///     Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255
    ///     is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessPct">
    ///     Number indicating percentage of full brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 100 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessStep">Change brightness by an amount.</param>
    /// <param name="brightnessStepPct">Change brightness by a percentage.</param>
    /// <param name="white">
    ///     Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 255 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="profile">Name of a light profile to use. eg: relax</param>
    /// <param name="flash">If the light should flash.</param>
    /// <param name="effect">Light effect.</param>
    public static void TurnOn(
        this LightEntity target,
        long? transition = null,
        object? rgbColor = null,
        object? rgbwColor = null,
        object? rgbwwColor = null,
        object? colorName = null,
        object? hsColor = null,
        object? xyColor = null,
        object? colorTemp = null,
        long? kelvin = null,
        long? brightness = null,
        long? brightnessPct = null,
        long? brightnessStep = null,
        long? brightnessStepPct = null,
        long? white = null,
        string? profile = null,
        object? flash = null,
        string? effect = null) {
        target.CallService("turn_on",
            new LightTurnOnParameters {
                Transition = transition, RgbColor = rgbColor, RgbwColor = rgbwColor, RgbwwColor = rgbwwColor,
                ColorName = colorName, HsColor = hsColor, XyColor = xyColor, ColorTemp = colorTemp, Kelvin = kelvin,
                Brightness = brightness, BrightnessPct = brightnessPct, BrightnessStep = brightnessStep,
                BrightnessStepPct = brightnessStepPct, White = white, Profile = profile, Flash = flash, Effect = effect,
            });
    }

    /// <summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
    /// <param name="target">The IEnumerable<LightEntity> to call this service for</param>
    /// <param name="transition">Duration it takes to get to next state.</param>
    /// <param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
    /// <param name="rgbwColor">
    ///     A list containing four integers between 0 and 255 representing the RGBW (red, green, blue,
    ///     white) color for the light. eg: [255, 100, 100, 50]
    /// </param>
    /// <param name="rgbwwColor">
    ///     A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue,
    ///     cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]
    /// </param>
    /// <param name="colorName">A human readable color name.</param>
    /// <param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
    /// <param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
    /// <param name="colorTemp">Color temperature for the light in mireds.</param>
    /// <param name="kelvin">Color temperature for the light in Kelvin.</param>
    /// <param name="brightness">
    ///     Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255
    ///     is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessPct">
    ///     Number indicating percentage of full brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 100 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="brightnessStep">Change brightness by an amount.</param>
    /// <param name="brightnessStepPct">Change brightness by a percentage.</param>
    /// <param name="white">
    ///     Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the
    ///     minimum brightness and 255 is the maximum brightness supported by the light.
    /// </param>
    /// <param name="profile">Name of a light profile to use. eg: relax</param>
    /// <param name="flash">If the light should flash.</param>
    /// <param name="effect">Light effect.</param>
    public static void TurnOn(
        this IEnumerable<LightEntity> target,
        long? transition = null,
        object? rgbColor = null,
        object? rgbwColor = null,
        object? rgbwwColor = null,
        object? colorName = null,
        object? hsColor = null,
        object? xyColor = null,
        object? colorTemp = null,
        long? kelvin = null,
        long? brightness = null,
        long? brightnessPct = null,
        long? brightnessStep = null,
        long? brightnessStepPct = null,
        long? white = null,
        string? profile = null,
        object? flash = null,
        string? effect = null) {
        target.CallService("turn_on",
            new LightTurnOnParameters {
                Transition = transition, RgbColor = rgbColor, RgbwColor = rgbwColor, RgbwwColor = rgbwwColor,
                ColorName = colorName, HsColor = hsColor, XyColor = xyColor, ColorTemp = colorTemp, Kelvin = kelvin,
                Brightness = brightness, BrightnessPct = brightnessPct, BrightnessStep = brightnessStep,
                BrightnessStepPct = brightnessStepPct, White = white, Profile = profile, Flash = flash, Effect = effect,
            });
    }
}

public static class NumberEntityExtensionMethods {
    ///<summary>Set the value of a Number entity.</summary>
    public static void SetValue(this NumberEntity target, NumberSetValueParameters data) {
        target.CallService("set_value", data);
    }

    ///<summary>Set the value of a Number entity.</summary>
    public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data) {
        target.CallService("set_value", data);
    }

    ///<summary>Set the value of a Number entity.</summary>
    ///<param name="target">The NumberEntity to call this service for</param>
    ///<param name="value">The target value the entity should be set to. eg: 42</param>
    public static void SetValue(this NumberEntity target, string? value = null) {
        target.CallService("set_value", new NumberSetValueParameters { Value = value });
    }

    ///<summary>Set the value of a Number entity.</summary>
    ///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
    ///<param name="value">The target value the entity should be set to. eg: 42</param>
    public static void SetValue(this IEnumerable<NumberEntity> target, string? value = null) {
        target.CallService("set_value", new NumberSetValueParameters { Value = value });
    }
}

public static class SceneEntityExtensionMethods {
    ///<summary>Activate a scene.</summary>
    public static void TurnOn(this SceneEntity target, SceneTurnOnParameters data) {
        target.CallService("turn_on", data);
    }

    ///<summary>Activate a scene.</summary>
    public static void TurnOn(this IEnumerable<SceneEntity> target, SceneTurnOnParameters data) {
        target.CallService("turn_on", data);
    }

    ///<summary>Activate a scene.</summary>
    ///<param name="target">The SceneEntity to call this service for</param>
    ///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
    public static void TurnOn(this SceneEntity target, long? transition = null) {
        target.CallService("turn_on", new SceneTurnOnParameters { Transition = transition });
    }

    ///<summary>Activate a scene.</summary>
    ///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
    ///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
    public static void TurnOn(this IEnumerable<SceneEntity> target, long? transition = null) {
        target.CallService("turn_on", new SceneTurnOnParameters { Transition = transition });
    }
}

public static class SwitchEntityExtensionMethods {
    ///<summary>Toggles a switch state</summary>
    public static void Toggle(this SwitchEntity target) {
        target.CallService("toggle");
    }

    ///<summary>Toggles a switch state</summary>
    public static void Toggle(this IEnumerable<SwitchEntity> target) {
        target.CallService("toggle");
    }

    ///<summary>Turn a switch off</summary>
    public static void TurnOff(this SwitchEntity target) {
        target.CallService("turn_off");
    }

    ///<summary>Turn a switch off</summary>
    public static void TurnOff(this IEnumerable<SwitchEntity> target) {
        target.CallService("turn_off");
    }

    ///<summary>Turn a switch on</summary>
    public static void TurnOn(this SwitchEntity target) {
        target.CallService("turn_on");
    }

    ///<summary>Turn a switch on</summary>
    public static void TurnOn(this IEnumerable<SwitchEntity> target) {
        target.CallService("turn_on");
    }
}

public static class UpdateEntityExtensionMethods {
    ///<summary>Removes the skipped version marker from an update.</summary>
    public static void ClearSkipped(this UpdateEntity target) {
        target.CallService("clear_skipped");
    }

    ///<summary>Removes the skipped version marker from an update.</summary>
    public static void ClearSkipped(this IEnumerable<UpdateEntity> target) {
        target.CallService("clear_skipped");
    }

    ///<summary>Install an update for this device or service</summary>
    public static void Install(this UpdateEntity target, UpdateInstallParameters data) {
        target.CallService("install", data);
    }

    ///<summary>Install an update for this device or service</summary>
    public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data) {
        target.CallService("install", data);
    }

    ///<summary>Install an update for this device or service</summary>
    ///<param name="target">The UpdateEntity to call this service for</param>
    ///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
    ///<param name="backup">Backup before installing the update, if supported by the integration.</param>
    public static void Install(this UpdateEntity target, string? version = null, bool? backup = null) {
        target.CallService("install", new UpdateInstallParameters { Version = version, Backup = backup });
    }

    ///<summary>Install an update for this device or service</summary>
    ///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
    ///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
    ///<param name="backup">Backup before installing the update, if supported by the integration.</param>
    public static void Install(this IEnumerable<UpdateEntity> target, string? version = null, bool? backup = null) {
        target.CallService("install", new UpdateInstallParameters { Version = version, Backup = backup });
    }

    ///<summary>Mark currently available update as skipped.</summary>
    public static void Skip(this UpdateEntity target) {
        target.CallService("skip");
    }

    ///<summary>Mark currently available update as skipped.</summary>
    public static void Skip(this IEnumerable<UpdateEntity> target) {
        target.CallService("skip");
    }
}
