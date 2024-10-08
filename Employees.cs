namespace LoginMaster;

public class Employees
{
    public int? Id { get; private set; }
    public string? Position { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public int? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }

    public Employees() //deafult constructor
    {
    }

    public Employees(int id, string? position, string? firstName, string? lastName, string? email, int? phoneNumber, string? address, string? city)
    {
        Id = id;
        Position = position;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        City = city;
    }
   
}