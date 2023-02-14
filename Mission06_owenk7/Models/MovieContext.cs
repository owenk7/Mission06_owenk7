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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormModel>().HasData(
                new FormModel
                {
                    movieid = 1,
                    title = "Die Hard",
                    year = 1988,
                    cat = "Action/Adventure",
                    director = "John McTiernan",
                    rating = "R",
                    edited = false,
                    lent = null,
                    notes = null
                },
                new FormModel
                {
                    movieid = 2,
                    title = "Die Hard 2",
                    year = 1990,
                    cat = "Action/Adventure",
                    director = "Renny Harlin",
                    rating = "R",
                    edited = false,
                    lent = null,
                    notes = null
                },
                new FormModel
                {
                    movieid = 3,
                    title = "Frozen 2",
                    year = 2019,
                    cat = "Family",
                    director = "Jennifer Lee, Chris Buck",
                    rating = "PG",
                    edited = true,
                    lent = null,
                    notes = null
                }
            );
        }
    }
}