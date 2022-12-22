using Domain.Models;
namespace Infrastructure.Services;

public class CourseService
{
    public List<Course> courses;

    public CourseService()
    {
        courses = new List<Course>();
    }
    public List<Course> GetCourses()
    {
        return courses;
    }
    public void AddCourse(Course course)
    {
        courses.Add(course);
    }
    public void UpdateCourse(Course course)
    {
        var find = courses.FirstOrDefault(x=>x.Id == course.Id);
        find.Id = course.Id;
        find.Title = course.Title;
        find.Description = course.Description;
        find.Free = course.Free;
        find.HasDiscount = course.HasDiscount;
    }
    public void Delete(int id)
    {
        courses.RemoveAt(id);
    }
}
