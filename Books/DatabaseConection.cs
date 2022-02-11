using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books
{
    public class DatabaseConection : DbContext
    {
        public DatabaseConection()
        {
            
        }

        public DatabaseConection(DbContextOptions<DatabaseConection> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Books;Integrated Security=True");
        }

        public DbSet<Models.Books> Books { get; set; }
    }
}
