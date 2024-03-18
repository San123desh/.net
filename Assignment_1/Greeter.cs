class Greeter
{
    public string Greet(string name, string dob)
    {
        var Fname = name;
        return Fname;

        // Console.WriteLine("Enter your full name:");
        // string fullName = Console.ReadLine();
        // return fullName;
        
       var date = DateTime.Parse(dob);
       var formattedDob = date.ToString("yyyy-MM-dd");
       return $"{Fname},{formattedDob}"
    }
}