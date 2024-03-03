class Car : Vehicle, IFuelEfficient
{
    public int ProducedYear {get;set;}
    private int fuelEfficiency;

    public Car(int vin, string brand, string model, int year):base(vin,brand, model)
    {
        ProducedYear = year;
    }
    public int DisplayFuelEfficiency()=> fuelEfficiency;

    public void SetFuelEfficiency(int efficiency)
    {
        fuelEfficiency = efficiency;
    }
    public override string DisplayInfo()
    {
         var details =  base.DisplayInfo();
        details += $"\nReleased Year:{ProducedYear}\nFuel Efficiency:{fuelEfficiency} Km/l";
        return details;
    }
}


