using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_owenk7.Models
{
    public class MovieContext : DbContext
    {
        // constructor                                      // new variable movies
        public MovieContext(DbContextOptions<MovieContext> movies) : base(movies)
        {
            //blank for now
        }

        // DbSet and pass FormModel, model that contains form
        public DbSet<FormModel> recommendations { get; set; }

        public DbSet<Category> Categories { get; set; }

        // seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }

                );
            mb.Entity<FormModel>().HasData(
                new FormModel
                {
                    Movieid = 1,
                    Title = "Die Hard",
                    Year = 1988,
                    CategoryId = 1,
                    Director = "John McTiernan",
                    Rating = "R",
                    Edited = false,
                    Lent = null,
                    Notes = null
                },
                new FormModel
                {
                    Movieid = 2,
                    Title = "Die Hard 2",
                    Year = 1990,
                    CategoryId = 1,
                    Director = "Renny Harlin",
                    Rating = "R",
                    Edited = false,
                    Lent = null,
                    Notes = null
                },
                new FormModel
                {
                    Movieid = 3,
                    Title = "Frozen 2",
                    Year = 2019,
                    CategoryId = 4,
                    Director = "Jennifer Lee, Chris Buck",
                    Rating = "PG",
                    Edited = true,
                    Lent = null,
                    Notes = null
                }
            );
        }
    }
}