using AutoMapper;
using api_rest.Resources;
using api_rest.Extensions;
using api_rest.Domain.Models;

namespace api_rest.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<User, UserResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfPlatform, opt => opt.MapFrom(src => src.UnitOfPlatform.ToDescriptionString()));
        }
    }
}
