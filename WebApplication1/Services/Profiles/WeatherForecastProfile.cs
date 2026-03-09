using AutoMapper;
using WebApplication1.Models;

namespace WebApplication1.Services.Profiles
{
    public class WeatherForecastProfile : Profile
    {
        public WeatherForecastProfile()
        {
            CreateMap<Weather, WeatherForecast>()
                .ForMember(dest => dest.TemperatureF,
                opt => opt.MapFrom(src => src.TemperatureC)
                )
                .ForMember(dest => dest.Date,
                opt=>opt.MapFrom(src => DateOnly.FromDateTime(src.Date))
                );
        }
    }
}
