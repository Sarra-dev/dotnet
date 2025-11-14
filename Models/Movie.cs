using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string name { get; set; }  

        public DateTime ReleaseDate { get; set; } 

        public bool WithSubtitles { get; set; }  

        public int? GenderId { get; set; }  

        public virtual Gender? Genre { get; set; }

        public virtual ICollection<Customer>? Customers { get; set; }  

        public Movie()
        {
        }
    }
}
