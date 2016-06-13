using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAppMovies.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

    public interface IMovieRepository
    {
        IQueryable<Movie> GetMovies();

    }
    public class InMemoryMovieRepository : IMovieRepository
    {
        public IQueryable<Movie> GetMovies()
        {

            return new[] 
            { 
                new Movie 
                {   id = 1, 
                    title = "GameOfThrones",
                    ReleaseDate = DateTime.Now, 
                    Genre = "fantasy",
                    Price = 10 
                } 
            }.AsQueryable();

           
        }
    }

}