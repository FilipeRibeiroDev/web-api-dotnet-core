using AutoMapper;
using WebApi.Domain.DTOs;
using WebApi.Domain.Model.EmployeeAggregate;

namespace WebApi.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));
        }
    }
}
