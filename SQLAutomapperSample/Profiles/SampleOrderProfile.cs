using AutoMapper;
using SQLAutomapperSample.DataAccess.Models;
using SQLAutomapperSample.Dtos;

namespace SQLAutomapperSample.Profiles
{
    public class SampleOrderProfile : Profile
    {
        public SampleOrderProfile()
        {
            CreateMap<SampleOrder, SampleOrderDto>()
                .ReverseMap();
        }
    }
}
