using Employee.Domain.Entities;

namespace Employee.Application.Interfaces;

public interface IEmployeeService
{
    Task<IEnumerable<Employee>> GetAllAsync();
    Task<Employee?> GetByIdAsync(Guid id);
    // TODO: Add create, update, delete methods
}