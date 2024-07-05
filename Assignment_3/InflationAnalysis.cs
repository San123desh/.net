using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

public class InflationAnalysis
{
    public List<Inflation> inflationData { get; private set; }

    public InflationAnalysis(string filePath)
    {
        inflationData = new List<Inflation>();
        ReadInflationData(filePath);
    }
    public void ReadInflationData(string filePath)
    {

        try
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                BadDataFound = null, // Ignore bad data lines
                Delimiter = ",",
                PrepareHeaderForMatch = args => args.Header.Trim().Replace(" ", "").Replace("\"", "")
            }))
            {
                csv.Context.RegisterClassMap<InflationMap>();
                inflationData = new List<Inflation>(csv.GetRecords<Inflation>());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the data: {ex.Message}");
        }

        // Return the list
        // return inflationData;
    }

    // public List<Inflation> GetInflationRatesForYear(int year)
    // {
    //     return inflationData.Where(item => item.Year == year).ToList();
    // }

    // public int? GetYearWithHighestInflation()
    // {

    //     var nepalData = inflationData.Where(item => item.RegionalMember == "Nepal");
    //     var highestInflation = nepalData.OrderByDescending(item => item.InflationRate).FirstOrDefault();
    //     return highestInflation?.Year;

    // }

    // public List<Inflation> GetTop10RegionsWithHighestInflation()
    // {
    //     return inflationData
    //         .OrderByDescending(item => item.InflationRate)
    //         .Take(10)
    //         .ToList();
    // }

    
    public List<Inflation> GetTop3SouthAsianCountriesWithLowestInflationForYear(int year)
    {
        var southAsianCountries = new List<string> { "Afghanistan", "Bangladesh", "Bhutan", "India", "Maldives", "Nepal", "Pakistan", "Sri Lanka" };
        var southAsianData = inflationData.Where(item => item.Year == year && southAsianCountries.Contains(item.RegionalMember));
        return southAsianData.OrderBy(item => item.InflationRate).Take(3).ToList();
    }

}
