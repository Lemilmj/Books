using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBooks.Models
{
    public class Books
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IdBook { get; set; }
        public string BookName { get; set; }
        public string CreationDate { get; set; }

    }
}