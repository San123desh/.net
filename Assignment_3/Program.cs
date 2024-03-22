var inflationAnalysis = new InflationAnalysis("Book1.csv");

var inflationRatesForYear = inflationAnalysis.GetInflationRatesForYear(2020);

Console.WriteLine("Inflation Rates for Year 2020:");
foreach (var inflationRate in inflationRatesForYear)
{
    Console.WriteLine($"{inflationRate.RegionalMember}:{inflationRate.InflationRate}");
}



