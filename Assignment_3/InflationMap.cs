using CsvHelper.Configuration;

public class InflationMap : ClassMap<Inflation>
{
    public InflationMap()
    {
        Map(m => m.RegionalMember).Name("RegionalMember");
        Map(m => m.Year).Name("Year");
        Map(m => m.InflationRate).Name("Inflation");
        Map(m => m.UnitOfMeasurement).Name("Unit of Measurement");
        Map(m => m.Subregion).Name(" Subregion");
        Map(m => m.CountryCode).Name(" Country Code");
    }
}
