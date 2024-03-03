var car = new Car(1234,"TOYOTA","Hilux",2020);
car.SetFuelEfficiency(40);
Console.WriteLine(car.DisplayInfo());

Console.WriteLine("----------------------------------");

var ecar = new ElectricCar(5678,"Tesla","Model S",2023, 400);
Console.WriteLine(ecar.DisplayInfo()); 





