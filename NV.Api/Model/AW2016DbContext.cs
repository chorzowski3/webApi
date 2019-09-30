using Microsoft.EntityFrameworkCore;
using NV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Api.Model
{
    public class AW2016DbContext : DbContext
    {
        public AW2016DbContext() { }

        public AW2016DbContext(DbContextOptions<AW2016DbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>().ToTable("Person");
            base.OnModelCreating(builder);
        }
    }
}
