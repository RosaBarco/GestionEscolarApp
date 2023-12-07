using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionApp.Models;
using GestionEscolarApp.Models;

namespace GestionApp.Data
{
    public class GestionAppContext : DbContext
    {
        public GestionAppContext (DbContextOptions<GestionAppContext> options)
            : base(options)
        {
        }

        public DbSet<GestionApp.Models.Alumno> Alumno { get; set; } = default!;
        public DbSet<GestionApp.Models.Profesor> Profesor { get; set; } = default!;
        public DbSet<GestionEscolarApp.Models.Materia> Materia { get; set; } = default!;
        public DbSet<GestionEscolarApp.Models.Calificacion> Calificacion { get; set; } = default!;
        public DbSet<GestionEscolarApp.Models.Asignada> Asignada { get; set; } = default!;
    }
}
