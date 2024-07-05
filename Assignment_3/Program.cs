var inflationAnalysis = new InflationAnalysis("Inflation.csv");


// var inflationRatesForYear = inflationAnalysis.GetInflationRatesForYear(2021);
// Console.WriteLine("Inflation Rates for Year 2021:");
// foreach (var inflationRate in inflationRatesForYear)
// {
//     Console.WriteLine($"{inflationRate.RegionalMember}:{inflationRate.InflationRate}");
// }

int? highestInflationYear = inflationAnalysis.GetYearWithHighestInflation();
if (highestInflationYear.HasValue)
{
    Console.WriteLine($"\nYear when Nepal had the highest inflation: {highestInflationYear.Value}");
}
else
{
    Console.WriteLine("\nNo data available for Nepal.");
}



