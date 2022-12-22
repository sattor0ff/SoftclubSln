using Domain.Models;
namespace Infrastructure.Services;

public class StudentService
{
    public List<Student> students;

    public StudentService()
    {
        students = new List<Student>();
    }
    public List<Student> GetStudents()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void UpdateStudent(Student student)
    {
        var find = students.FirstOrDefault(x=>x.Id == student.Id);
        find.FirstName = student.FirstName;
        find.LastName = student.LastName;
        find.BirthDate = student.BirthDate;
        find.Address = student.Address;
    }
    public void Delete(int id)
    {
        students.RemoveAt(id);
    }
}
