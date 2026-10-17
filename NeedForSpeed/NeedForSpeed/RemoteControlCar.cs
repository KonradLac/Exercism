namespace NeedForSpeed;

class RemoteControlCar(int speed, int batteryDrain)
{
    private readonly int batteryDrain = batteryDrain;
    private int batteryPercentage = 100;
    private readonly int speed = speed;
    private int distanceDriven = default;

    public bool BatteryDrained() => batteryPercentage < batteryDrain;

    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if(BatteryDrained())
        {
            return;
        }
        distanceDriven += speed;
        batteryPercentage -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}
