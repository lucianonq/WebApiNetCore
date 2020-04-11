﻿using Microsoft.EntityFrameworkCore;
using MiPrimerWebApiM3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
    }
}
