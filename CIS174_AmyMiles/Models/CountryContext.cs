using Microsoft.EntityFrameworkCore;

namespace CIS174_AmyMiles.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }


        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Division> Divisions { get; set; } = null!;
        public DbSet<Sport> Sports { get; set; } = null!;
        public DbSet<Setting> Settings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Division>().HasData(
                new Division {  DivisionID = "winter", Name = "Winter Olympics"},
                new Division { DivisionID = "summer", Name = "Summer Olympics" },
                new Division { DivisionID = "para", Name = "Paralympics" },
                new Division { DivisionID = "youth", Name = "Youth Olympic Games" }
            );

            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "curl", Name = "Curling"},
                new Sport { SportID = "bob", Name = "Bobsleigh" },
                new Sport { SportID = "diving", Name = "Diving" },
                new Sport { SportID = "cycling", Name = "Road Cycling" },
                new Sport { SportID = "archery", Name = "Archery" },
                new Sport { SportID = "canoe", Name = "Canoe Sprint" },
                new Sport { SportID = "bdance", Name = "Breakdancing" },
                new Sport { SportID = "skateb", Name = "Skateboarding" }
            );

            modelBuilder.Entity<Setting>().HasData(
                new Setting { SettingID = "out", Name = "Outdoor"},
                new Setting { SettingID = "in", Name = "Indoor" }
            );

            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "canada", Name = "Canada", DivisionID = "winter", SportID = "curl", SettingID = "in", LogoImage = "canada.jpg"},
                new { CountryID = "sweden", Name = "Sweden", DivisionID = "winter", SportID = "curl", SettingID = "in", LogoImage = "sweden.jpg" },
                new { CountryID = "great_britain", Name = "Great Britain", DivisionID = "winter", SportID = "curl", SettingID = "in", LogoImage = "great_britain.jpg" },
                new { CountryID = "jamaica", Name = "Jamaica", DivisionID = "winter", SportID = "bob", SettingID = "out", LogoImage = "jamaica.jpg" },
                new { CountryID = "italy", Name = "Italy", DivisionID = "winter", SportID = "bob", SettingID = "out", LogoImage = "italy.jpg" },
                new { CountryID = "japan", Name = "Japan", DivisionID = "winter", SportID = "bob", SettingID = "out", LogoImage = "japan.jpg" },
                new { CountryID = "germany", Name = "Germany", DivisionID = "summer", SportID = "diving", SettingID = "in", LogoImage = "germany.jpg" },
                new { CountryID = "china", Name = "China", DivisionID = "summer", SportID = "diving", SettingID = "in", LogoImage = "china.jpg" },
                new { CountryID = "mexico", Name = "Mexico", DivisionID = "summer", SportID = "diving", SettingID = "in", LogoImage = "mexico.jpg" },
                new { CountryID = "brazil", Name = "Brazil", DivisionID = "summer", SportID = "cycling", SettingID = "out", LogoImage = "brazil.jpg" },
                new { CountryID = "netherlands", Name = "Netherlands", DivisionID = "summer", SportID = "cycling", SettingID = "out", LogoImage = "netherlands.jpg" },
                new { CountryID = "usa", Name = "USA", DivisionID = "summer", SportID = "cycling", SettingID = "out", LogoImage = "united_states.jpg" },
                new { CountryID = "thailand", Name = "Thailand", DivisionID = "para", SportID = "archery", SettingID = "in", LogoImage = "thailand.jpg" },
                new { CountryID = "uruguay", Name = "Uruguay", DivisionID = "para", SportID = "archery", SettingID = "in", LogoImage = "uruguay.jpg" },
                new { CountryID = "ukraine", Name = "Ukraine", DivisionID = "para", SportID = "archery", SettingID = "in", LogoImage = "ukraine.jpg" },
                new { CountryID = "austria", Name = "Austria", DivisionID = "para", SportID = "canoe", SettingID = "out", LogoImage = "austria.jpg" },
                new { CountryID = "pakistan", Name = "Pakistan", DivisionID = "para", SportID = "canoe", SettingID = "out", LogoImage = "pakistan.jpg" },
                new { CountryID = "zimbabwe", Name = "Zimbabwe", DivisionID = "para", SportID = "canoe", SettingID = "out", LogoImage = "zimbabwe.jpg" },
                new { CountryID = "france", Name = "France", DivisionID = "youth", SportID = "bdance", SettingID = "in", LogoImage = "france.jpg" },
                new { CountryID = "cyprus", Name = "Cyprus", DivisionID = "youth", SportID = "bdance", SettingID = "in", LogoImage = "cyprus.jpg" },
                new { CountryID = "russia", Name = "Russia", DivisionID = "youth", SportID = "bdance", SettingID = "in", LogoImage = "russia.jpg" },
                new { CountryID = "finland", Name = "Finland", DivisionID = "youth", SportID = "skateb", SettingID = "out", LogoImage = "finland.jpg" },
                new { CountryID = "slovakia", Name = "Slovakia", DivisionID = "youth", SportID = "skateb", SettingID = "out", LogoImage = "slovakia.jpg" },
                new { CountryID = "portugal", Name = "Portugal", DivisionID = "youth", SportID = "skateb", SettingID = "out", LogoImage = "portugal.jpg" }

            );
        }


    }
}
