using System.Data.Entity;

namespace WRL.DataLayer.EntitiesConfigurations
{
    public class WrlConfigModelBuilder
    {
        private readonly DbModelBuilder _modelBuilder;

        public WrlConfigModelBuilder(DbModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Configure()
        {
            _modelBuilder.Properties<string>().Configure(p => p.IsUnicode());
            _modelBuilder.Configurations
                .Add(new SubwayStationConfiguration())
                .Add(new ApartmentOwnerConfiguration())
                .Add(new RegionConfiguration())
                .Add(new StreetConfiguration())
                .Add(new ApartmentConfiguration());
        }
    }
}
