using Microsoft.EntityFrameworkCore;
using GestionApp.Data;

namespace GestionApp.Models
{
    public class SeedAlumno
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GestionAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GestionAppContext>>()
                ))
            {
                //EN CASO DE CONTEXTO NULO TIENE UN ERROR.
                if (context == null || context.Alumno == null)
                {
                    throw new ArgumentException("NULL GestionAppContext");
                }

                if (context.Alumno.Any())
                {
                    //LA BASE DE DATOS RETORNA TODO LO QUE CONTIENE ESTA CLASE
                    return;
                }

                context.Alumno.AddRange(
                    new Alumno
                    {
                        NombreAlumno = "Rosa",
                        ApellidoAlumno = "Barco",
                        MatriculaAlumno = 18000634
                    },
                    new Alumno
                    {
                        NombreAlumno = "Lorenzo",
                        ApellidoAlumno = "Villegas",
                        MatriculaAlumno = 18000815
                    },
                    new Alumno
                    {
                        NombreAlumno = "Ignacio",
                        ApellidoAlumno = "Chavez",
                        MatriculaAlumno = 18000567
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
