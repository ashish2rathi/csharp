namespace ExtendedPropertyPatterns
{
    public class ProvinceOrStateTaxProperty
    {
        public string? ProvinceOrState { get; set; }
    }

    public class CalculateTax
    {
        public string? CountryName { get; set; }
        public ProvinceOrStateTaxProperty? ProvinceTaxProperty { get; set; }
    }

    public class Csharp8Computing
    {
        private static decimal ComputePrice(CalculateTax calculate, decimal price) =>

        calculate switch
        {
            { ProvinceTaxProperty: { ProvinceOrState: "Québec" } } => 1.14975M * price,
            { ProvinceTaxProperty: { ProvinceOrState: "Alberta" } } => 1.05M * price,
            { ProvinceTaxProperty: { ProvinceOrState: "Ontario" } } => 1.13M * price,
            _ => 0
        };
    }

    public class Csharp10Computing
    {
        private static decimal ComputePrice(CalculateTax calculate, decimal price) =>
        calculate switch
        {
            { ProvinceTaxProperty.ProvinceOrState: "Québec" } => 1.14975M * price,
            { ProvinceTaxProperty.ProvinceOrState: "Alberta" } => 1.05M * price,
            { ProvinceTaxProperty.ProvinceOrState: "Ontario" } => 1.13M * price,
            _ => 0

        };
    }
}