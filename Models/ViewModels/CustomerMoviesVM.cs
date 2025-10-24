namespace MyFirstApp.Models.ViewModels;



public class CustomerMovieVM
{
    public List<Movie> movies { get; set; }
    public Customer customer {get;set;}
    public CustomerMovieVM() 
    {
        
    }
}