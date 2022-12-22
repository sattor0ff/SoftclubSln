using Domain.Models;
using Infrastructure.Services;

var student1 = new Student();

student1.Id = 1;
student1.FirstName = "ArdasheR";
student1.LastName = "Sattori";
student1.BirthDate = DateTime.Now;
student1.Address = "A.Navoi";

var student2 = new Student();

student2.Id = 2;
student2.FirstName = "Important";
student2.LastName = "Person";
student2.BirthDate = DateTime.Now;
student2.Address = "Softclub";

var studentService = new StudentService();

studentService.AddStudent(student1);
studentService.AddStudent(student2);

System.Console.WriteLine("\nStudents: ");
foreach(var studentElement in studentService.GetStudents())
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{studentElement.Id}\n{studentElement.FirstName} {studentElement.LastName}\n{studentElement.BirthDate}\n{studentElement.Address}");
}

System.Console.WriteLine("\nAfter Student Delete: ");


studentService.Delete(1);

foreach(var studentElement in studentService.GetStudents())
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{studentElement.Id}\n{studentElement.FirstName} {studentElement.LastName}\n{studentElement.BirthDate}\n{studentElement.Address}");
}

System.Console.WriteLine("\nAfterUpdate: ");

student1.Id = 1;
student1.FirstName = "Omen";
student1.LastName = "By HP";
student1.BirthDate = DateTime.Now;
student1.Address = "Softclub";

studentService.UpdateStudent(student1);

foreach(var studentElement in studentService.GetStudents())
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{studentElement.Id}\n{studentElement.FirstName} {studentElement.LastName}\n{studentElement.BirthDate}\n{studentElement.Address}");
}



System.Console.WriteLine("\nTeachers: ");

var teacher1 = new Teacher();

teacher1.Id = 1;
teacher1.FirstName = "English";
teacher1.LastName = "Teacher";
teacher1.Position = "somePosition";
teacher1.ExperienceAmount = 5;

var teacher2 = new Teacher();

teacher2.Id = 2;
teacher2.FirstName = "Math";
teacher2.LastName = "Teacher";
teacher2.Position = "somePosition";
teacher2.ExperienceAmount = 8;

var tService = new TeacherService();

tService.AddTeacher(teacher1);
tService.AddTeacher(teacher2);

foreach(var tElement in tService.GetTeachers())
{

    System.Console.WriteLine($"\n{tElement.Id}\n{tElement.FirstName} {tElement.LastName}\n{tElement.Position}\n{tElement.ExperienceAmount} years");
}

System.Console.WriteLine("\nAfter Teacher Delete: ");

tService.Delete(0);

foreach(var tElement in tService.GetTeachers())
{
    
    System.Console.WriteLine($"\n{tElement.Id}\n{tElement.FirstName} {tElement.LastName}\n{tElement.Position}\n{tElement.ExperienceAmount} years");
}


System.Console.WriteLine("\nCourses: ");

var course1 = new Course();

course1.Id = 1;
course1.Title = "qwerty";
course1.Description = "blabla";
course1.Free = 123;
course1.HasDiscount = true;

var course2 = new Course();

course2.Id = 2;
course2.Title = "blabla";
course2.Description = "qwerty";
course2.Free = 321;
course2.HasDiscount = false;

var cService = new CourseService();

cService.AddCourse(course1);
cService.AddCourse(course2);

foreach (var cElement in cService.GetCourses())
{
    System.Console.WriteLine($"\n{cElement.Id}\n{cElement.Title}\n{cElement.Description}\n{cElement.Free}\n{cElement.HasDiscount}");
}

System.Console.WriteLine("\nAfter Course Delete: ");

cService.Delete(1);

foreach (var cElement in cService.GetCourses())
{
    System.Console.WriteLine($"\n{cElement.Id}\n{cElement.Title}\n{cElement.Description}\n{cElement.Free}\n{cElement.HasDiscount}");
    
}

System.Console.WriteLine("\nPost: ");

var post1 = new Post();

post1.Id = 1;
post1.Title = "postTitle1";
post1.Description = "postDescription1";
post1.VoteAmount = 1234;
post1.CreatedAt = DateTime.Now;

var post2 = new Post();

post2.Id = 2;
post2.Title = "postTitle2";
post2.Description = "postDescription2";
post2.VoteAmount = 4321;
post2.CreatedAt = DateTime.MaxValue;

var pService = new PostService();

pService.AddPost(post1);
pService.AddPost(post2);

foreach (var pElement in pService.GetPosts())
{
    System.Console.WriteLine($"\n{pElement.Id}\n{pElement.Title}\n{pElement.Description}\n{pElement.VoteAmount}\n{pElement.CreatedAt}");
}

System.Console.WriteLine("\nAfter Post Delete: ");

pService.Delete(0);

foreach (var pElement in pService.GetPosts())
{
    System.Console.WriteLine($"\n{pElement.Id}\n{pElement.Title}\n{pElement.Description}\n{pElement.VoteAmount}\n{pElement.CreatedAt}");
}
