using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Books
    {
        [Key]
       public int IdBook { get; set; }
       public string BookName { get; set; }
       public string CreationDate { get; set; }
        
    }
}
