using DependencyInjection.Models;

namespace DependencyInjection.Repos
{
    public interface IStudentRepo
    {
        void AddStudent(StudentModel student);
        List<StudentModel> GetStudents();
        List<StudentModel> DeleteStudent(int id);
    }
}