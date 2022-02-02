using AutoMapper;
using api_rest.Resources;
using api_rest.Domain.Models;

namespace api_rest.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<AuthUserResource, User>();
        }
    }
}
