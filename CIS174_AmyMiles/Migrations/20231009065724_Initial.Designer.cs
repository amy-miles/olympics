﻿// <auto-generated />
using CIS174_AmyMiles.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CIS174_AmyMiles.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20231009065724_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CIS174_AmyMiles.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DivisionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SettingID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("SettingID");

                    b.HasIndex("SportID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "canada",
                            DivisionID = "winter",
                            LogoImage = "canada.jpg",
                            Name = "Canada",
                            SettingID = "in",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "sweden",
                            DivisionID = "winter",
                            LogoImage = "sweden.jpg",
                            Name = "Sweden",
                            SettingID = "in",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "great_britain",
                            DivisionID = "winter",
                            LogoImage = "great_britain.jpg",
                            Name = "Great Britain",
                            SettingID = "in",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "jamaica",
                            DivisionID = "winter",
                            LogoImage = "jamaica.jpg",
                            Name = "Jamaica",
                            SettingID = "out",
                            SportID = "bob"
                        },
                        new
                        {
                            CountryID = "italy",
                            DivisionID = "winter",
                            LogoImage = "italy.jpg",
                            Name = "Italy",
                            SettingID = "out",
                            SportID = "bob"
                        },
                        new
                        {
                            CountryID = "japan",
                            DivisionID = "winter",
                            LogoImage = "japan.jpg",
                            Name = "Japan",
                            SettingID = "out",
                            SportID = "bob"
                        },
                        new
                        {
                            CountryID = "germany",
                            DivisionID = "summer",
                            LogoImage = "germany.jpg",
                            Name = "Germany",
                            SettingID = "in",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "china",
                            DivisionID = "summer",
                            LogoImage = "china.jpg",
                            Name = "China",
                            SettingID = "in",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "mexico",
                            DivisionID = "summer",
                            LogoImage = "mexico.jpg",
                            Name = "Mexico",
                            SettingID = "in",
                            SportID = "diving"
                        },
                        new
                        {
                            CountryID = "brazil",
                            DivisionID = "summer",
                            LogoImage = "brazil.jpg",
                            Name = "Brazil",
                            SettingID = "out",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "netherlands",
                            DivisionID = "summer",
                            LogoImage = "netherlands.jpg",
                            Name = "Netherlands",
                            SettingID = "out",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "usa",
                            DivisionID = "summer",
                            LogoImage = "united_states.jpg",
                            Name = "USA",
                            SettingID = "out",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "thailand",
                            DivisionID = "para",
                            LogoImage = "thailand.jpg",
                            Name = "Thailand",
                            SettingID = "in",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "uruguay",
                            DivisionID = "para",
                            LogoImage = "uruguay.jpg",
                            Name = "Uruguay",
                            SettingID = "in",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "ukraine",
                            DivisionID = "para",
                            LogoImage = "ukraine.jpg",
                            Name = "Ukraine",
                            SettingID = "in",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "austria",
                            DivisionID = "para",
                            LogoImage = "austria.jpg",
                            Name = "Austria",
                            SettingID = "out",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "pakistan",
                            DivisionID = "para",
                            LogoImage = "pakistan.jpg",
                            Name = "Pakistan",
                            SettingID = "out",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "zimbabwe",
                            DivisionID = "para",
                            LogoImage = "zimbabwe.jpg",
                            Name = "Zimbabwe",
                            SettingID = "out",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "france",
                            DivisionID = "youth",
                            LogoImage = "france.jpg",
                            Name = "France",
                            SettingID = "in",
                            SportID = "bdance"
                        },
                        new
                        {
                            CountryID = "cyprus",
                            DivisionID = "youth",
                            LogoImage = "cyprus.jpg",
                            Name = "Cyprus",
                            SettingID = "in",
                            SportID = "bdance"
                        },
                        new
                        {
                            CountryID = "russia",
                            DivisionID = "youth",
                            LogoImage = "russia.jpg",
                            Name = "Russia",
                            SettingID = "in",
                            SportID = "bdance"
                        },
                        new
                        {
                            CountryID = "finland",
                            DivisionID = "youth",
                            LogoImage = "finland.jpg",
                            Name = "Finland",
                            SettingID = "out",
                            SportID = "skateb"
                        },
                        new
                        {
                            CountryID = "slovakia",
                            DivisionID = "youth",
                            LogoImage = "slovakia.jpg",
                            Name = "Slovakia",
                            SettingID = "out",
                            SportID = "skateb"
                        },
                        new
                        {
                            CountryID = "portugal",
                            DivisionID = "youth",
                            LogoImage = "portugal.jpg",
                            Name = "Portugal",
                            SettingID = "out",
                            SportID = "skateb"
                        });
                });

            modelBuilder.Entity("CIS174_AmyMiles.Models.Division", b =>
                {
                    b.Property<string>("DivisionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DivisionID");

                    b.ToTable("Divisions");

                    b.HasData(
                        new
                        {
                            DivisionID = "winter",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            DivisionID = "summer",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            DivisionID = "para",
                            Name = "Paralympics"
                        },
                        new
                        {
                            DivisionID = "youth",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("CIS174_AmyMiles.Models.Setting", b =>
                {
                    b.Property<string>("SettingID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SettingID");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            SettingID = "out",
                            Name = "Outdoor"
                        },
                        new
                        {
                            SettingID = "in",
                            Name = "Indoor"
                        });
                });

            modelBuilder.Entity("CIS174_AmyMiles.Models.Sport", b =>
                {
                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportID");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportID = "curl",
                            Name = "Curling"
                        },
                        new
                        {
                            SportID = "bob",
                            Name = "Bobsleigh"
                        },
                        new
                        {
                            SportID = "diving",
                            Name = "Diving"
                        },
                        new
                        {
                            SportID = "cycling",
                            Name = "Road Cycling"
                        },
                        new
                        {
                            SportID = "archery",
                            Name = "Archery"
                        },
                        new
                        {
                            SportID = "canoe",
                            Name = "Canoe Sprint"
                        },
                        new
                        {
                            SportID = "bdance",
                            Name = "Breakdancing"
                        },
                        new
                        {
                            SportID = "skateb",
                            Name = "Skateboarding"
                        });
                });

            modelBuilder.Entity("CIS174_AmyMiles.Models.Country", b =>
                {
                    b.HasOne("CIS174_AmyMiles.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionID");

                    b.HasOne("CIS174_AmyMiles.Models.Setting", "Setting")
                        .WithMany()
                        .HasForeignKey("SettingID");

                    b.HasOne("CIS174_AmyMiles.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportID");

                    b.Navigation("Division");

                    b.Navigation("Setting");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
