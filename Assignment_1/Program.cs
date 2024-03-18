// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Enter name: ");
// string name = Console.ReadLine();
// string capName = name.ToUpper();
// DateTime dob = DateTime.TryParse(dobInput);

// DateTime dob = default;
// var parsingSuccess = false;
// while(!parsingSuccess){
//     Console.WriteLine("Dob (year-m-d)");
//     string dobInput = Console.ReadLine();   
//     parsingSuccess = DateTime.TryParse(dobInput, out dob);
// }

// var ageOut = GetAge(dob);
// Console.WriteLine(ageOut);

// string GetAge(DateTime dob){
//     TimeSpan age = DateTime.Now - dob;
//     var ageInDay = age.TotalDays;
//     var Years = (int) (ageInDay / 365);
//     var RemDays = ageInDay % 365;
//     var months = (int)( RemDays / 30);
//     var daysAfterMonths = (int) (RemDays % 30);
//     var output = $"{Years} Year- {months} Months- {daysAfterMonths} Days";
//     return output;
// }

Greeter a = new();
// var fullName = a.Greet("Sandesh Shrestha");
// Console.WriteLine(fullName);

//5
// var cfullName = fullName.ToUpper();
// Console.WriteLine("Hello, " + cfullName +" ji");

//6
// Console.WriteLine("Enter your name:");
// var fullName = a.Greet(Console.ReadLine());
// Console.WriteLine("Your name:"+ fullName);


Console.Write("Enter your date of birth (yyyy/mm/dd): ");
string dobInput = Console.ReadLine();
DateTime dob = DateTime.Parse(dobInput);
string formattedDob = dob.Greet(dob);
Console.WriteLine("Date of birth: " + formattedDob);


// string dob = Console.ReadLine();
// string formattedDob = a.Greet(FormatDob(dob));
// Console.WriteLine("Your date of birth is: " + formattedDob);