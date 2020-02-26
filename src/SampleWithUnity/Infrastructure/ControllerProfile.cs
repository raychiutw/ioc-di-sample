using AutoMapper;
using SampleWithUnity.Models;

namespace SampleWithUnity.Infrastructure
{
    public class ControllerProfile : Profile
    {
        public ControllerProfile()
        {
            this.CreateMap<FooDto, FooViewModel>();
        }
    }
}