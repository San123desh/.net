class ElectricCar:Car
{
    public static int BatteryCapacity;
    public ElectricCar(int vin,string brand, string model, int year, int range)
    :base(vin, brand,model,year)
    {
        BatteryCapacity = range;
    }
    public void ChargeCar()
    {
        Console.WriteLine("Car is charging");
    }
    public override string DisplayInfo()
    {
        var details = base.DisplayInfo();
        details += $"\nBattery capacity: {BatteryCapacity} kwh";
        return details;
    }
}





