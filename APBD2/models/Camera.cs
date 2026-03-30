namespace APBD2.models;

public class Camera : Device
{
    public string Resolution { get; private set; }
    public int OpticalZoom { get; private set; }

    public Camera(string name, string brand, string resolution, int opticalZoom) : base(name, brand)
    {
        Resolution = resolution;
        OpticalZoom = opticalZoom;
    }
}
