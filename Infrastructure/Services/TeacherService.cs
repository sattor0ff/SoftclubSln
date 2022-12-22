using Domain.Models;
namespace Infrastructure.Services;

public class TeacherService
{
    public List<Teacher> teachers;

    public TeacherService()
    {
        teachers = new List<Teacher>();
    }
    public List<Teacher> GetTeachers()
    {
        return teachers;
    }
    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }
    public void UpdateStudent(Teacher teacher)
    {
        var find = teachers.FirstOrDefault(x=>x.Id == teacher.Id);
        find.Id = teacher.Id;
        find.FirstName = teacher.FirstName;
        find.LastName = teacher.LastName;
        find.Position = teacher.Position;
        find.ExperienceAmount = teacher.ExperienceAmount;
    }
    public void Delete(int id)
    {
        teachers.RemoveAt(id);
    }
}