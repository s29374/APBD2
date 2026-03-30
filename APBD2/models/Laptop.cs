namespace APBD2.models;

public class Laptop : Device
{
    public string Processor { get; private set; }
    public int RamGb { get; private set; }

    public Laptop(string name, string brand, string processor, int ramGb) : base(name, brand)
    {
        Processor = processor;
        RamGb = ramGb;
    }
}
