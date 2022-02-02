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
                new Category { CategoryId = 1, Category_name = "Comedy" },
                new Category { CategoryId = 2, Category_name = "Action" },
                new Category { CategoryId = 3, Category_name = "Romance" }
                );

            mb.Entity<MovieModel>().HasData(
                //new MovieModel
                //{
                //    Movie_id = 4,
                //    Category_id = 2,
                //    Title = "Harry Potter",
                //    Year = 2000,
                //    Director = "JK Rowling",
                //    Rating = "PG",
                //    Edited = false,
                //    Lent_to = "",
                //    Notes = ""
                //},
                new MovieModel
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Hot Rod",
                    Year = 2000,
                    Director = "Smartest Man",
                    Rating = "PG",
                    Edited = false,
                    Lent_to = "",
                    Notes = ""
                },
                new MovieModel
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "13 Going On 30",
                    Year = 2002,
                    Director = "Cute Girl",
                    Rating = "G",
                    Edited = true,
                    Lent_to = "",
                    Notes = ""
                },

                new MovieModel
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "SpiderMan No Way Home",
                    Year = 2021,
                    Director = "Russo Brothers",
                    Rating = "PG",
                    Edited = false,
                    Lent_to = "",
                    Notes = ""
                }


            );
        }

    }
}
