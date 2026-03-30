namespace APBD2.models;

public class Projector : Device
{
    public string NativeResolution { get; private set; }
    public int BrightnessLumens { get; private set; }

    public Projector(string name, string brand, string nativeResolution, int brightnessLumens) : base(name, brand)
    {
        NativeResolution = nativeResolution;
        BrightnessLumens = brightnessLumens;
    }
}
