using Movies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies.API.Data
{
    public class MoviesContextSeed
    {
        public static void SeedAsync(MoviesAPIContext moviesAPIContext)
        {
            if(!moviesAPIContext.Movie.Any())
            {
                List<Movie> movies = new List<Movie>
                {
                    new Movie
                    {
                        Id = 1,
                        Genre = "Drama",
                        ImageUrl = "images/src",
                        Rating = "4",
                        Owner="alice",
                        ReleaseDate = new DateTime(1994,5,5),
                        Title = "The shawshank redemption"
                    },
                    new Movie
                    {
                        Id = 2,
                        Genre = "Crime",
                        ImageUrl = "images/src",
                        Rating = "4.3",
                        Owner="alice",
                        ReleaseDate = new DateTime(1972,5,5),
                        Title = "The GodFather"
                    },
                    new Movie
                    {
                        Id = 3,
                        Genre = "Mystery",
                        ImageUrl = "images/src",
                        Rating = "4.4",
                        Owner="alice",
                        ReleaseDate = new DateTime(1972,5,5),
                        Title = "The Great escape"
                    },
                    new Movie
                    {
                        Id = 4,
                        Genre = "Family",
                        ImageUrl = "images/src",
                        Rating = "4.5",
                        Owner="Ananth",
                        ReleaseDate = new DateTime(1981,2,1),
                        Title = "Beethoven"
                    },
                    new Movie
                    {
                        Id = 5,
                        Genre = "Family",
                        ImageUrl = "images/src",
                        Rating = "4.5",
                        Owner="Ananth",
                        ReleaseDate = new DateTime(1981,2,1),
                        Title = "Beethoven"
                    }
                };
                moviesAPIContext.Movie.AddRange(movies);
                moviesAPIContext.SaveChanges();
            }
        }
    }
}
