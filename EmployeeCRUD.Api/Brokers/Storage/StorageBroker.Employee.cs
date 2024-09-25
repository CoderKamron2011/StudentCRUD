using EmployeeCRUD.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Api.Brokers.Storage
{
    public partial class StorageBroker
    {
        public ValueTask<Employee> InsertStudentAsync(Employee employee)=>
            this.InsertAsync(employee);

        public IQueryable<Employee> SelectAllStudents()=>
            this.SelectAll<Employee>();

        public ValueTask<Employee> SelectStudentByIdAsync(int employeeId)=>
            this.SelectAsync<Employee>(employeeId);

        public ValueTask<Employee> UpdateStudentAsync(Employee employee) =>
            this.UpdateAsync<Employee>(employee);

        public ValueTask<Employee> DeleteStudentAsync(Employee employee)=>
            this.DeleteAsync(employee);
    }
}
