using Microsoft.EntityFrameworkCore;
//using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace LINQ
{
    class AnimalContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=LOCALHOST\SQLEXPRESS;Database=Animal;Integrated Security=True");
        }
    }
}
