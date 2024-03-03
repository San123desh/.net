class Car : Vehicle, IFuelEfficient
{
    public int ProducedYear {get;set;}

    public Car(int vin, string brand, string model, int year):base(vin,brand, model)
    {
        ProducedYear = year;
    }
    public int DisplayFuelEfficiency()=> 14;
    public override string DisplayInfo()
    {
         var details =  base.DisplayInfo();
        details += $"\nReleased Year:{ProducedYear}";
        return details;
    }
}


