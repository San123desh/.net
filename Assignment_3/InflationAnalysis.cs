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

    public List<Inflation> GetInflationRatesForYear(int year)
    {
        return inflationData.Where(item => item.Year == year).ToList();
    }

    // public Inflation GetYearWithHighestInflation(string country)
    // {

    //     // string country = "Nepal";
    //     return inflationData
    //         .Where(item => item.RegionalMember == "Nepal")
    //         .OrderByDescending(item => item.InflationRate)
    //         .FirstOrDefault();

    // }

    // public List<Inflation> GetTop10RegionsWithHighestInflation()
    // {
    //     return inflationData
    //         .OrderByDescending(item => item.InflationRate)
    //         .Take(10)
    //         .ToList();
    // }

    // private bool IsSouthAsianCountry(string country)
    // {
    //     if(country == null )
    //     {
    //         return false;
    //     }
    //     List<string> southAsianCountries = new List<string> { "Nepal", "India", "Pakistan", "Bangladesh", "Sri Lanka", "Bhutan", "Maldives" };
    //     return southAsianCountries.Contains(country);
    // }
    // public List<Inflation> GetTop3SouthAsianCountriesWithLowestInflationForYear(int year)
    // {
    //     return inflationData
    //         .Where(item => item.Year == year && IsSouthAsianCountry(item.RegionalMember))
    //         .OrderBy(item => item.InflationRate)
    //         .Take(3)
    //         .ToList();
    // }

}
