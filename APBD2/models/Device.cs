namespace APBD2.models;

public class Device
{
    public Guid Id { get; }
    public string Name { get; private set; }
    public string Brand { get; private set; }
    public DeviceStatus Status { get; private set; }

    protected Device(string name, string brand)
    {
        Id = Guid.NewGuid();
        Name = name;
        Brand = brand;
        Status = DeviceStatus.Available;
    }

    public void MarkAsAvailable()
    {
        Status = DeviceStatus.Available;
    }

    public void MarkAsRented()
    {
        Status = DeviceStatus.Rented;
    }

    public void MarkAsUnavailable()
    {
        Status = DeviceStatus.Unavailable;
    }

    public void MarkAsInService()
    {
        Status = DeviceStatus.InService;
    }
}
