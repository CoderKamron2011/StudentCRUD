using EmployeeCRUD.Api.Models;

namespace EmployeeCRUD.Api.Brokers.Storage
{
    public partial interface IStorageBroker
    {
        ValueTask<Employee> InsertStudentAsync(Employee employee);
        IQueryable<Employee> SelectAllStudents();
        ValueTask<Employee> SelectStudentByIdAsync(int employeeId);
        ValueTask<Employee> UpdateStudentAsync(Employee employe);
        ValueTask<Employee> DeleteStudentAsync(Employee employe);
    }
}
