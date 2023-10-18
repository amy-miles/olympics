namespace CIS174_AmyMiles.Models
{
    public class OlympicSession
    {
        //pg 345
        private const string CountriesKey = "countrieskey";
        private const string CountKey = "countrycount";
        private const string DivisionKey = "divisionkey";
        private const string SportKey = "sportkey";

        private ISession session { get; set; }
        public OlympicSession(ISession session ) => this.session = session;

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject( CountriesKey, countries );
            session.SetInt32(CountKey, countries.Count );
        }

        public List<Country> GetMyCountries() => session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public int? GetMyCountryCount() => session.GetInt32(CountKey);

        public void SetActiveDivision(string activeDivision) => session.SetString(DivisionKey, activeDivision);
        public string GetActiveDivision() => session.GetString(DivisionKey) ?? string.Empty;

        public void SetActiveSport(string aciveSport) => session.SetString(SportKey, aciveSport);
        public string GetActiveSport() => session.GetString(SportKey) ?? string.Empty;

        public void RemoveMyCountries()
        {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}
