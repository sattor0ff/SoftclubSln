namespace Domain.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }

    public object UpdateStudent(string v)
    {
        throw new NotImplementedException();
    }
}
