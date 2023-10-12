using CRUD_EF.Models;

namespace CRUD_EF.Repositories;

public interface IStudentInterface
{
    List<Student> GetStudents();
    Student GetStudent(int id);
    void AddStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
}