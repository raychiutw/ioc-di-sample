using AutoMapper;
using SampleWithUnity.Models;

namespace SampleWithUnity.Infrastructure
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            this.CreateMap<Foo, FooDto>();
        }
    }
}