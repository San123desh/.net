public abstract class Vehicle
{
    public int VIN {get;}
    public string Brand { get; set;}
    public string Model { get; set; }

    // protected string EngineType;
    public Vehicle(int vin,string brand ,string model)
    {
        VIN = vin;
        Brand = brand;
        Model = model;
    }
    public virtual string DisplayInfo()
    {
        var vehicleInfo = $"Brand name:{Brand}\nModel:{Model}\nVIN:{VIN}";
        return vehicleInfo;
    }
}