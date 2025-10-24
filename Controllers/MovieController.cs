using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;


namespace MyFirstApp.Controllers;



public class MovieController : Controller
{
    public MovieController()
    {
        
    }
    public IActionResult Index()
    {
        var movies = new List<Movie>() 
        {
            new Movie{Id=1,name="Name1"},
            new Movie{Id=2,name="Name2"},
        };

        return View(movies);
    }
    
}