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
        [Required]
        public int movieid { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public string cat { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public bool edited { get; set; }

        public string lent { get; set; }

        [MaxLength(25)]
        public string notes { get; set; }
    }
}