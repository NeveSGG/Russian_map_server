﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_map_server
{
    public class CitiesContext:DbContext
    {
        public DbSet<City> cities { get; set; } = null!;
         public CitiesContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=citiesBd;Trusted_Connection=True;");
        }

    }

}
