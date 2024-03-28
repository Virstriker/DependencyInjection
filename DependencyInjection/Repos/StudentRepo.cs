using DependencyInjection.Models;

namespace DependencyInjection.Repos
{
    public class StudentRepo : IStudentRepo
    {
        List<StudentModel> students = new List<StudentModel>();
        public void AddStudent(StudentModel student)
        {
            students.Add(student);
        }
        public List<StudentModel> GetStudents()
        {
            return students;
        }
        public List<StudentModel> DeleteStudent(int id)
        {
            students.RemoveAll(s => s.Id == id);
            return students;
        }
    }
}
