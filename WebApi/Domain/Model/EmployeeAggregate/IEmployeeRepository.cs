using WebApi.Domain.DTOs;

namespace WebApi.Domain.Model.EmployeeAggregate
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);

        List<EmployeeDTO> Get(int pageNumber, int pageQuantity);
        Employee? Get(int id);
    }
}
