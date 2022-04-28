using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore3.Models
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext()
        {

        }
        public MovieDBContext(DbContextOptions<MovieDBContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7MGGRB4;Initial Catalog=Sql15;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<movie> Movies { get; set; }
    }
}
