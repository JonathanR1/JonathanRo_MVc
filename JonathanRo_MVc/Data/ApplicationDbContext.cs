using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADS_Project.Models;
using JonathanRo_MVc.Models;

using Microsoft.EntityFrameworkCore;

namespace JonathanRo_MVc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<EstudianteViewModel> Estudiantes { get; set; }

        public DbSet<MateriaViewModel> Materias { get; set; }

        public DbSet<ProfesorViewModel> Profesores { get; set; }

        public DbSet<CarreraViewModel> Carreras { get; set; }

        public DbSet<GruposViewModel> Grupos { get; set; }
    }
}
