using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Movies.Models
{
    public class MovieFormContext : DbContext
    {
        //Constructor
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
        {
            //leave blank
        }

        public DbSet<MovieModel> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            //put in sample data here
            mb.Entity<Category>().HasData(
                new Category { category_id = 1, category_name = "Comedy" },
                new Category { category_id = 2, category_name = "Action" },
                new Category { category_id = 3, category_name = "Romance" }
                );

            mb.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    movie_id = 1,
                    category_id = 1,
                    title = "Hot Rod",
                    year = 2000,
                    director = "Smartest Man",
                    rating = "PG",
                    edited = false,
                    lent_to = "",
                    notes = ""
                },
                new MovieModel
                {
                    movie_id = 2,
                    category_id = 2,
                    title = "13 Going On 30",
                    year = 2002,
                    director = "Cute Girl",
                    rating = "G",
                    edited = true,
                    lent_to = "",
                    notes = ""
                },

                new MovieModel
                {
                    movie_id = 3,
                    category_id = 3,
                    title = "SpiderMan No Way Home",
                    year = 2021,
                    director = "Russo Brothers",
                    rating = "PG",
                    edited = false,
                    lent_to = "",
                    notes = ""
                }


            );
        }

    }
}
