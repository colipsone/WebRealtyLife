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
            var city = new City {Name = "Киев"};
            var region = new Region
            {
                Name = "Голосеевский",
                CityId = city.Id
            };
            context.Cities.Add(city);
            context.Regions.Add(region);
        }
    }
}
