namespace Identity.Domain.Entities;

public class Customer : ApplicationUser
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}