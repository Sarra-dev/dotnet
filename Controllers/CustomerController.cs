using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models.ViewModels;
using MyFirstApp.Models;


namespace MyFirstApp.Controllers;

public class CustomerController : Controller
{

    public ActionResult IndexVM()
    {
        var c = new Customer { Id = 1, name = "Customer A" };
        var customermovievm = new CustomerMovieVM()
        {
            movies = GetAll(),
            customer = c,
        };
        return View(customermovievm);

    }

    private List<Movie> GetAll()
    {
        var movies = new List<Movie>()
        {
            new Movie {Id=1 , name = "Name 1"},
            new Movie {Id=2 , name = "Name 2"}
        };
        return movies;
    }
}