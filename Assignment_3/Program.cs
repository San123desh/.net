var inflationAnalysis = new InflationAnalysis("Inflation.csv");


// var inflationRatesForYear = inflationAnalysis.GetInflationRatesForYear(2021);
// Console.WriteLine("Inflation Rates for Year 2021:");
// foreach (var inflationRate in inflationRatesForYear)
// {
//     Console.WriteLine($"{inflationRate.RegionalMember}:{inflationRate.InflationRate}");
// }


//b

// int? highestInflationYear = inflationAnalysis.GetYearWithHighestInflation();
// if (highestInflationYear.HasValue)
// {
//     Console.WriteLine($"\nYear when Nepal had the highest inflation: {highestInflationYear.Value}");
// }
// else
// {
//     Console.WriteLine("\nNo data available for Nepal.");
// }


//c

// var top10 = inflationAnalysis.GetTop10RegionsWithHighestInflation();
// Console.WriteLine("\nTop 10 regions with highest inflation of all time:");
// foreach (var regions in top10)
// {
//     Console.WriteLine($"{regions.RegionalMember}:{regions.InflationRate}");
// }


//d

var top3SACfor2020 = inflationAnalysis.GetTop3SouthAsianCountriesWithLowestInflationForYear(2020);
Console.WriteLine("\nTop 3 South Asian countries with lowest inflation for 2020:");
foreach(var country in top3SACfor2020){
    Console.WriteLine($"{country.RegionalMember}:{country.InflationRate}");
}




