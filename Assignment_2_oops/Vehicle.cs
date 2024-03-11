public abstract class Vehicle
{
    public int VIN {get;}
    public string Brand { get; set;}
    string model = string.Empty;
    public string Model
    {
        get { return model; }
        set {model = value; }
    }
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


