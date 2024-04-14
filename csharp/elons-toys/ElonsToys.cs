using System;

class RemoteControlCar
{
    private int _battery = 100;
    private int _distance = 0;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distance} meters";

    public string BatteryDisplay()
    {
        switch (_battery)
        {
            case 0:
                return "Battery empty";
            default:
                return $"Battery at {_battery}%";
        }
    }

    public void Drive()
    {
        if (_battery > 0)
        {
            _battery -= 1;
            _distance += 20;
        }
    }
}
