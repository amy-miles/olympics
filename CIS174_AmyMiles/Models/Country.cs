namespace CIS174_AmyMiles.Models
{
    public class Country
    {
        public string CountryID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public Division Division { get; set; } = null!;
        public Sport Sport { get; set; } = null!;
        public Setting Setting { get; set; } = null!;
        public string LogoImage { get; set; } = string.Empty;

    }
}
