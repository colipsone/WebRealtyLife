using AutoMapper;
using WRL.Model.Entity.Apartment;
using WRL.Web.Api.ViewModels;

namespace WRL.Web.Api
{
    public static class AutoMapperConfig
    {
        public static void MapEntities()
        {
            Mapper.CreateMap<Apartment, ApartmentViewModel>();
        }
    }
}