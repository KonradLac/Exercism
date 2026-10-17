namespace NeedForSpeed;

class RaceTrack(int distance)
{
    private readonly int distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < distance && !car.BatteryDrained())
        {
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}
