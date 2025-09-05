namespace employee.Domain.Entities;

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public DateTime HireDate { get; set; }
}