// string fullName = "Sandesh Shrestha";
// Console.WriteLine(fullName);
// string cfullName = fullName.ToUpper();
// Console.WriteLine("Hello, " +cfullName + " Ji !");

Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
// Console.WriteLine("Name: " + name);

Console.WriteLine("Enter your Dob:(MM/DD/YYYY) ");
string? DobInput = Console.ReadLine();
DateTime Dob = DateTime.Parse(DobInput);

Console.WriteLine("Hello, " + name + " Ji!");
Console.WriteLine("Your DOB: " + Dob.ToString("dddd,dd MMMM yyyy"));

string GetAge(DateTime dob)
{
    TimeSpan age = DateTime.Now - dob;
    var ageInDay = age.TotalDays;
    var Years = (int)(ageInDay / 365);
    var RemDays = ageInDay % 365;
    var months = (int)(RemDays / 30);
    var daysAfterMonths = (int)(RemDays % 30);
    var weeks = daysAfterMonths % 7;
    // int years = age.Days / 365;
    // int months = (age.Days % 365) / 30;
    // int weeks = ((age.Days % 365) % 30) / 7;
    // int days = ((age.Days % 365) % 30) % 7;
    return $"{Years} Year {months} Months {weeks} Week {daysAfterMonths} Days";
}
string? age = GetAge(Dob);
Console.WriteLine("Your Age: " + age);





