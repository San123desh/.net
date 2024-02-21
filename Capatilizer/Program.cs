// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Enter name: ");
// string name = Console.ReadLine();
// string capName = name.ToUpper();
// DateTime dob = DateTime.TryParse(dobInput);

DateTime dob = default;
var parsingSuccess = false;
while(!parsingSuccess){
    Console.WriteLine("Dob (year-m-d)");
    string dobInput = Console.ReadLine();   
    parsingSuccess = DateTime.TryParse(dobInput, out dob);
}

var ageOut = GetAge(dob);
Console.WriteLine(ageOut);

string GetAge(DateTime dob){
    TimeSpan age = DateTime.Now - dob;
    var ageInDay = age.TotalDays;
    var Years = (int) (ageInDay / 365);
    var RemDays = ageInDay % 365;
    var months = (int)( RemDays / 30);
    var daysAfterMonths = (int) (RemDays % 30);
    var output = $"{Years} Year- {months} Months- {daysAfterMonths} Days";
    return output;
}

