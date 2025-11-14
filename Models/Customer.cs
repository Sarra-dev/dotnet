namespace MyFirstApp.Models;

public class Customer
{
    public int Id { get; set; }
    public string name {get;set;}
    public Customer() 
    {
        
    }
    public List<Movie> movies { get; set; }
    public MembershipType? membershipType { get; set; }
}