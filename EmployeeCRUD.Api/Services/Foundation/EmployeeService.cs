using EmployeeCRUD.Api.Brokers.Storage;
using EmployeeCRUD.Api.Models;

namespace EmployeeCRUD.Api.Services.Foundation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IStorageBroker storageBroker;
        public EmployeeService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;
        public ValueTask<Employee> AddEmployeeAsync(Employee employee)=>
            this.storageBroker.InsertStudentAsync(employee);

        public ValueTask<Employee> ModifyEmployeeAsync(Employee employee)=>
            this.storageBroker.UpdateStudentAsync(employee);

        public ValueTask<Employee> RemoveEmployeeByIdAsync(Employee employee) =>
            this.storageBroker.DeleteStudentAsync(employee);

        public IQueryable<Employee> RetrieveAllEmployee() =>
            this.storageBroker.SelectAllStudents();

        public ValueTask<Employee> RetrieveEmployeeByIdAsync(int employeeId)=>
            this.storageBroker.SelectStudentByIdAsync(employeeId);
    }
}
