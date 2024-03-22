class InflationAnalysis:Inflation
{
    public List<Inflation> inflationData;

     public InflationAnalysis(string filePath)
    {
        inflationData = new List<Inflation>();
        ReadInflationData(filePath);
    }
    public List<Inflation> ReadInflationData(string filePath)
    {

        foreach(var line in File.ReadAllLines(filePath).Skip(1))
        {
        
            var columns = line.Split(',');

            // creating new inflation obj and setting its properties
            var inflation = new Inflation{
                RegionalMember = columns[0],
                Year = int.Parse(columns[1]),
                InflationRate = double.Parse(columns[2]),
                UnitOfMeasurement = columns[3],
                Subregion = columns[4],
                CountryCode = columns[5]
            };
            // Add new inflation obj to the list  
            //list populated
            inflationData.Add(inflation);

        }

        //return list
        return inflationData;  
    }

     public List<Inflation> GetInflationRatesForYear(int year)
    {
        return inflationData.Where(item => item.Year == year).ToList();
    }

    // public Inflation GetYearWithHighestInflation(string country)
    // {
    //     return inflationData
    //         .Where(item => item.RegionalMember == country)
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
