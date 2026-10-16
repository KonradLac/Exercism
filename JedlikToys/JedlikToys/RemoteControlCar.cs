namespace JedlikToys;

public class RemoteControlCar
{
    private int distanceDriven;
    private int batteryPercentage = 100;

    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {distanceDriven} meters";

    public string BatteryDisplay()
    {
        if (batteryPercentage == 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {batteryPercentage}%";
        }
    }

    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            distanceDriven += 20;
            batteryPercentage--;
        }
        else
        {
            return;
        }
    }
}
