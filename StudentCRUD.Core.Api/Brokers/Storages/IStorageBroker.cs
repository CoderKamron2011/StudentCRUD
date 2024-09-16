using StudentCRUD.Core.Api.Models.Students;

namespace StudentCRUD.Core.Api.Brokers.Storages
{
    public interface IStorageBroker
    {
        ValueTask<Student> InsertStudentAsync(Student student);
    }
}