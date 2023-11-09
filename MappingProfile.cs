using AutoMapper;
using CompanyEmployee.Entities.Models;
using CompanyEmployee.Shared.DataTransferObjects;

namespace CompanyEmployee
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {

            /* Auto-mapper for Company classThis CreateMap....is not working as expected
             CreateMap<Company, CompanyDto>()
                 .ForMember(c => c.FullAddress,
                 opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));*/

            //Auto-mapper for Company class...this is working as expected
            CreateMap<Company, CompanyDto>()
                .ForMember("FullAddress", 
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            //Auto-mapper for Employee class
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
