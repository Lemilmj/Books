using System;
using System.Data.Entity;
using System.Linq;

namespace WebBooks
{
    public class DatabaseConections : DbContext
    {
        // Your context has been configured to use a 'DatabaseConections' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WebBooks.DatabaseConections' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DatabaseConections' 
        // connection string in the application configuration file.
        public DatabaseConections()
            : base("name=DatabaseConections")
        {
        }

         public virtual DbSet<WebBooks.Models.Books> MyBooks { get; set; }
    }

}