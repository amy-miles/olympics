namespace CIS174_AmyMiles.Models
{
    public class OlympicViewModel
    {
        public string ActiveDivision { get; set; } = "all";
        public string ActiveSport { get; set;} = "all";

        public List<Country> Countries { get; set; } = new List<Country>();
        public List<Division> Divisions { get; set; } = new List<Division>();
        public List<Sport> Sports { get; set; } = new List<Sport>();

        //methods to help view determine active link
        public string CheckActiveDivision(string d) => d.ToLower() == ActiveDivision.ToLower() ? "active" : "";

        public string CheckActiveSport(string d) => d.ToLower() == ActiveSport.ToLower() ? "active" : "";

    }
}
