class Car : Vehicle, IFuelEfficient
{
    public int PropertyB {get;set;}
    public int FuelEfficiency {get; set;}

    public Car(int vin, string brand, string model, int year):base(vin,brand, model)
    {
        PropertyB = year;
        // EngineType = "Gasoline";
    }
   
    public int DisplayFuelEfficiency()=> 14;

    public override string DisplayInfo()
    {
         var details =  base.DisplayInfo();
        details += $"\nReleased Year:{PropertyB}";
        return details;
    }

}