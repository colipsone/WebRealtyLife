using System.Text;
using WRL.Model.Entity.Apartment;

namespace WRL.DataLayer.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<WRL.DataLayer.WrlDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WRL.DataLayer.WrlDbContext context)
        {
            var city = new City {Name = "Kiyv"};
            var region = new Region
            {
                Name = "Holossevskii",
                CityId = city.Id
            };
            var street = new Street
            {
                Name = "Petropavloskaya",
                RegionId = region.Id
            };
            var apartment = new Apartment
            {
                StreetId = street.Id,
                HouseNumber = "15"
            };
            context.Cities.Add(city);
            context.Regions.Add(region);
            context.Streets.Add(street);
            context.Apartments.Add(apartment);
        }
    }
}
