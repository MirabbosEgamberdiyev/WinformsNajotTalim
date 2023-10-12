using CRUD_EF.DataContext;
using CRUD_EF.Models;

namespace CRUD_EF.Repositories;

public class StudentRepository : IStudentInterface
{
    private readonly StudentDbContext dbContext;

    public StudentRepository()
    {
        dbContext = new StudentDbContext();
    }

    public void AddStudent(Student student)
    {
        dbContext.Students.Add(student);
        dbContext.SaveChanges();
    }
    public void DeleteStudent(int id)
    {
        var student = GetStudent(id);
        dbContext.Students.Remove(student);
        dbContext.SaveChanges();
    }
    public void UpdateStudent(Student student)
    {
        dbContext.Students.Update(student);
        dbContext.SaveChanges();
    }
    public Student GetStudent(int id)
        => dbContext.Students.FirstOrDefault(s => s.Id == id);

    public List<Student> GetStudents()
        => dbContext.Students.ToList();
}
