using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_owenk7.Models
{
    public class FormModel
    {
        [Key]
        public int? Movieid { get; set; }

        [Required(ErrorMessage = "Enter a Movie Name.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the year the movie was made.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the director of the movie.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Choose a Movie Rating")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

        // build relationship to category table
        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}