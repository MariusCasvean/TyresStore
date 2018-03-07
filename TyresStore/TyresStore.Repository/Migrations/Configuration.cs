namespace TyresStore.Repository.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using TyresStore.Repository.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TyresStore.Repository.TyresStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TyresStoreContext context)
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle{Manufacturer="Ford", Model="Focus", Year=2015, Color="Gray", Price=18600, Power="175 hp", SpeedLimit="185 km/h", Transmission="Manual", Consumption="6.3 l/100 km"},
                new Vehicle{Manufacturer="BMV", Model="X3", Year=2017, Color="Black", Price=32600, Power="385 hp", SpeedLimit="220 km/h", Transmission="Manual", Consumption="8.9 l/100 km"},
                new Vehicle{Manufacturer="VW", Model="Passat", Year=2001, Color="Red", Price=19250, Power="165 hp", SpeedLimit="190 km/h", Transmission="Manual", Consumption="7.5 l/100 km"},
                new Vehicle{Manufacturer="Opel", Model="Corsa", Year=2013, Color="Red", Price=9600, Power="105 hp", SpeedLimit="180 km/h", Transmission="Manual", Consumption="4.8 l/100 km"},
                //New added items
                new Vehicle{Manufacturer="Alfa Romeo", Model="Stelvio", Year=2015, Color="Green", Price=42600, Power="185 hp", SpeedLimit="190 km/h", Transmission="Manual", Consumption="7.3 l/100 km"},
                new Vehicle{Manufacturer="Aston Martin", Model="Vulcan", Year=2016, Color="White", Price=44560, Power="285 hp", SpeedLimit="230 km/h", Transmission="Manual", Consumption="8.3 l/100 km"},
                new Vehicle{Manufacturer="Audi", Model="A3", Year=2011, Color="Silver", Price=24500, Power="193 hp", SpeedLimit="200 km/h", Transmission="Manual", Consumption="6.4 l/100 km"},
                new Vehicle{Manufacturer="Fiat", Model="Punto", Year=2012, Color="Blue", Price=13250, Power="135 hp", SpeedLimit="170 km/h", Transmission="Manual", Consumption="5.9 l/100 km"},
                new Vehicle{Manufacturer="Bugatti", Model="Veyron", Year=2017, Color="Black", Price=1225670, Power="785 hp", SpeedLimit="290 km/h", Transmission="Auto", Consumption="12.4 l/100 km"},
                new Vehicle{Manufacturer="Chevrolet", Model="Sonic", Year=2002, Color="Red", Price=21140, Power="125 hp", SpeedLimit="205 km/h", Transmission="Manual", Consumption="5.8 l/100 km"},
                new Vehicle{Manufacturer="Citroen", Model="Berlingo", Year=2012, Color="White", Price=23355, Power="144 hp", SpeedLimit="195 km/h", Transmission="Manual", Consumption="6.3 l/100 km"},
                new Vehicle{Manufacturer="Ferrari", Model="488Spider", Year=2017, Color="Blue", Price=242000, Power="455 hp", SpeedLimit="250 km/h", Transmission="Auto", Consumption="11.2 l/100 km"},
                new Vehicle{Manufacturer="Honda", Model="Civic", Year=2015, Color="Blue Metallic", Price=17500, Power="195 hp", SpeedLimit="210 km/h", Transmission="Manual", Consumption="7.0 l/100 km"},
                new Vehicle{Manufacturer="Lexus", Model="GS350", Year=2017, Color="Black", Price=72800, Power="395 hp", SpeedLimit="240 km/h", Transmission="Auto", Consumption="9.1 l/100 km"},
                new Vehicle{Manufacturer="Mercedes", Model="C-Class Sedan", Year=2018, Color="Silver", Price=142540, Power="295 hp", SpeedLimit="240 km/h", Transmission="Auto", Consumption="8.4 l/100 km"},
                new Vehicle{Manufacturer="Porche", Model="718Cayman", Year=2017, Color="White", Price=42000, Power="355 hp", SpeedLimit="230 km/h", Transmission="Manual", Consumption="9.9 l/100 km"},
                new Vehicle{Manufacturer="Subaru", Model="Impreza", Year=2009, Color="Silver", Price=28900, Power="165 hp", SpeedLimit="195 km/h", Transmission="Manual", Consumption="7.9 l/100 km"},
                new Vehicle{Manufacturer="Toyota", Model="Corolla", Year=2008, Color="Brown", Price=38900, Power="183 hp", SpeedLimit="185 km/h", Transmission="Manual", Consumption="7.1 l/100 km"},
                new Vehicle{Manufacturer="Mazda", Model="CX-3", Year=2017, Color="Red", Price=67830, Power="345 hp", SpeedLimit="230 km/h", Transmission="Auto", Consumption="8.9 l/100 km"},
                new Vehicle{Manufacturer="Dacia", Model="Duster", Year=2016, Color="White", Price=14550, Power="114 hp", SpeedLimit="200 km/h", Transmission="Manual", Consumption="7.4 l/100 km"},
                new Vehicle{Manufacturer="Jaguar", Model="SF", Year=2016, Color="White", Price=62900, Power="395 hp", SpeedLimit="235 km/h", Transmission="Auto", Consumption="9.3 l/100 km"},
                new Vehicle{Manufacturer="Land Rover", Model="LRX", Year=2018, Color="Silver", Price=154200, Power="390 hp", SpeedLimit="230 km/h", Transmission="Manual", Consumption="9.8 l/100 km"},
                new Vehicle{Manufacturer="Maserati", Model="Ghibli", Year=2017, Color="Blue", Price=543110, Power="535 hp", SpeedLimit="260 km/h", Transmission="Auto", Consumption="11.3 l/100 km"},
                new Vehicle{Manufacturer="Dodge", Model="Viper", Year=2017, Color="Red", Price=421500, Power="435 hp", SpeedLimit="240 km/h", Transmission="Auto", Consumption="10.2 l/100 km"}
                //up to here
            };

            vehicles.ForEach(v => context.Vehicles.AddOrUpdate(x => new { x.Manufacturer, x.Model, x.Year, x.Color, x.Price, x.Power, x.SpeedLimit, x.Transmission, x.Consumption }, v)); //add from color to consumption
            context.SaveChanges();

            var tyres = new List<Tyre>
            {
                new Tyre{VehicleId=1,Brand="Pirelli", Season="Winter", ArticleCode="205/55R16 91V TL", Price=100.75},
                new Tyre{VehicleId=1,Brand="GoodYear", Season="Summer",  ArticleCode="205/55R16 91W TL", Price=85.75},
                new Tyre{VehicleId=1,Brand="Dunlop", Season="All",  ArticleCode="225/75R16 90W TL", Price=185.6},
                new Tyre{VehicleId=1,Brand="Continental", Season="Winter",  ArticleCode="205/55R16 91V TL", Price=205.5},
                new Tyre{VehicleId=2,Brand="Pirelli", Season="Summer",  ArticleCode="245/75R16	55V TL", Price=302.6},
                new Tyre{VehicleId=2,Brand="Continental", Season="All",  ArticleCode="205/55R16 91W TL", Price=104},
                new Tyre{VehicleId=3,Brand="GoodYear", Season="Winter",  ArticleCode="245/75R16	55V TL", Price=155.9},
                new Tyre{VehicleId=3,Brand="Pirelli", Season="All",  ArticleCode="205/55R16 91V TL", Price=274.6},
                new Tyre{VehicleId=3,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=300},
                //new tyres added
                new Tyre{VehicleId=4,Brand="CAMAC", Season="Winter", ArticleCode="205/55R16 91V TL", Price=140.75},
                new Tyre{VehicleId=4,Brand="GoodYear", Season="Summer",  ArticleCode="205/55R16 91W TL", Price=95.75},
                new Tyre{VehicleId=4,Brand="Dunlop", Season="All",  ArticleCode="225/75R16 90W TL", Price=165.3},
                new Tyre{VehicleId=5,Brand="Continental", Season="Winter",  ArticleCode="205/55R16 91V TL", Price=305.5},
                new Tyre{VehicleId=5,Brand="Pirelli", Season="Summer",  ArticleCode="245/75R16	55V TL", Price=300.6},
                new Tyre{VehicleId=5,Brand="Continental", Season="All",  ArticleCode="205/55R16 91W TL", Price=120},
                new Tyre{VehicleId=5,Brand="GoodYear", Season="Winter",  ArticleCode="245/75R16	55V TL", Price=155.0},
                new Tyre{VehicleId=6,Brand="Pirelli", Season="All",  ArticleCode="205/55R16 91V TL", Price=276.6},
                new Tyre{VehicleId=7,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=360},
                new Tyre{VehicleId=8,Brand="Pirelli", Season="Winter", ArticleCode="205/55R16 91V TL", Price=150.75},
                new Tyre{VehicleId=8,Brand="GoodYear", Season="Summer",  ArticleCode="205/55R16 91W TL", Price=185.75},
                new Tyre{VehicleId=8,Brand="Dunlop", Season="All",  ArticleCode="225/75R16 90W TL", Price=285.6},
                new Tyre{VehicleId=9,Brand="Continental", Season="Winter",  ArticleCode="205/55R16 91V TL", Price=265.5},
                new Tyre{VehicleId=9,Brand="Pirelli", Season="Summer",  ArticleCode="245/75R16	55V TL", Price=202.6},
                new Tyre{VehicleId=9,Brand="Continental", Season="All",  ArticleCode="205/55R16 91W TL", Price=174},
                new Tyre{VehicleId=10,Brand="GoodYear", Season="Winter",  ArticleCode="245/75R16	55V TL", Price=175.9},
                new Tyre{VehicleId=10,Brand="Pirelli", Season="All",  ArticleCode="205/55R16 91V TL", Price=274.6},
                new Tyre{VehicleId=10,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=200},
                new Tyre{VehicleId=10,Brand="Pirelli", Season="Winter", ArticleCode="205/55R16 91V TL", Price=105.75},
                new Tyre{VehicleId=11,Brand="GoodYear", Season="Summer",  ArticleCode="205/55R16 91W TL", Price=185.75},
                new Tyre{VehicleId=11,Brand="Dunlop", Season="All",  ArticleCode="225/75R16 90W TL", Price=125.6},
                new Tyre{VehicleId=11,Brand="Continental", Season="Winter",  ArticleCode="205/55R16 91V TL", Price=105.5},
                new Tyre{VehicleId=11,Brand="Pirelli", Season="Summer",  ArticleCode="245/75R16	55V TL", Price=332.6},
                new Tyre{VehicleId=11,Brand="Continental", Season="All",  ArticleCode="205/55R16 91W TL", Price=134},
                new Tyre{VehicleId=12,Brand="GoodYear", Season="Winter",  ArticleCode="245/75R16	55V TL", Price=255.9},
                new Tyre{VehicleId=12,Brand="Pirelli", Season="All",  ArticleCode="205/55R16 91V TL", Price=174.6},
                new Tyre{VehicleId=13,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=200},
                new Tyre{VehicleId=13,Brand="Pirelli", Season="Winter", ArticleCode="205/55R16 91V TL", Price=120.75},
                new Tyre{VehicleId=13,Brand="GoodYear", Season="Summer",  ArticleCode="205/55R16 91W TL", Price=185.75},
                new Tyre{VehicleId=13,Brand="Dunlop", Season="All",  ArticleCode="225/75R16 90W TL", Price=181.6},
                new Tyre{VehicleId=14,Brand="Continental", Season="Winter",  ArticleCode="205/55R16 91V TL", Price=205.0},
                new Tyre{VehicleId=15,Brand="Pirelli", Season="Summer",  ArticleCode="245/75R16	55V TL", Price=304.6},
                new Tyre{VehicleId=16,Brand="Continental", Season="All",  ArticleCode="205/55R16 91W TL", Price=124},
                new Tyre{VehicleId=17,Brand="GoodYear", Season="Winter",  ArticleCode="245/75R16	55V TL", Price=125.9},
                new Tyre{VehicleId=17,Brand="Pirelli", Season="All",  ArticleCode="205/55R16 91V TL", Price=272.6},
                new Tyre{VehicleId=17,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=100},
                new Tyre{VehicleId=17,Brand="Pirelli", Season="Winter", ArticleCode="205/55R16 91V TL", Price=104.75},
                new Tyre{VehicleId=17,Brand="GoodYear", Season="Summer",  ArticleCode="205/55R16 91W TL", Price=185.75},
                new Tyre{VehicleId=17,Brand="Dunlop", Season="All",  ArticleCode="225/75R16 90W TL", Price=125.6},
                new Tyre{VehicleId=18,Brand="Continental", Season="Winter",  ArticleCode="205/55R16 91V TL", Price=305.5},
                new Tyre{VehicleId=18,Brand="Pirelli", Season="Summer",  ArticleCode="245/75R16	55V TL", Price=305.6},
                new Tyre{VehicleId=18,Brand="Continental", Season="All",  ArticleCode="205/55R16 91W TL", Price=103},
                new Tyre{VehicleId=18,Brand="GoodYear", Season="Winter",  ArticleCode="245/75R16	55V TL", Price=132.9},
                new Tyre{VehicleId=18,Brand="Pirelli", Season="All",  ArticleCode="205/55R16 91V TL", Price=226.6},
                new Tyre{VehicleId=19,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=100},
                new Tyre{VehicleId=19,Brand="Pirelli", Season="Winter", ArticleCode="205/55R16 91V TL", Price=106.75},
                new Tyre{VehicleId=19,Brand="GoodYear", Season="Summer",  ArticleCode="205/55R16 91W TL", Price=83.75},
                new Tyre{VehicleId=19,Brand="Dunlop", Season="All",  ArticleCode="225/75R16 90W TL", Price=145.6},
                new Tyre{VehicleId=19,Brand="Continental", Season="Winter",  ArticleCode="205/55R16 91V TL", Price=225.5},
                new Tyre{VehicleId=19,Brand="Pirelli", Season="Summer",  ArticleCode="245/75R16	55V TL", Price=324.6},
                new Tyre{VehicleId=20,Brand="Continental", Season="All",  ArticleCode="205/55R16 91W TL", Price=124},
                new Tyre{VehicleId=20,Brand="GoodYear", Season="Winter",  ArticleCode="245/75R16	55V TL", Price=125.9},
                new Tyre{VehicleId=20,Brand="Pirelli", Season="All",  ArticleCode="205/55R16 91V TL", Price=273.6},
                new Tyre{VehicleId=21,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=330},
                new Tyre{VehicleId=21,Brand="Dunlop", Season="All",  ArticleCode="225/75R16 90W TL", Price=135.6},
                new Tyre{VehicleId=21,Brand="Continental", Season="Winter",  ArticleCode="205/55R16 91V TL", Price=215.5},
                new Tyre{VehicleId=21,Brand="Pirelli", Season="Summer",  ArticleCode="245/75R16	55V TL", Price=102.6},
                new Tyre{VehicleId=22,Brand="Continental", Season="All",  ArticleCode="205/55R16 91W TL", Price=124},
                new Tyre{VehicleId=23,Brand="GoodYear", Season="Winter",  ArticleCode="245/75R16	55V TL", Price=125.9},
                new Tyre{VehicleId=23,Brand="Pirelli", Season="All",  ArticleCode="205/55R16 91V TL", Price=224.6},
                new Tyre{VehicleId=23,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=320},
                new Tyre{VehicleId=24,Brand="Continental", Season="Summer",  ArticleCode="225/75R16 90W TL", Price=320}
                //up to here
            };
            tyres.ForEach(t => context.Tyres.AddOrUpdate(x => new { x.VehicleId, x.Brand, x.Season, x.ArticleCode }, t));
            context.SaveChanges();
        }
    }
}
