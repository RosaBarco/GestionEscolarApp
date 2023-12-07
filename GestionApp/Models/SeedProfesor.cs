using Microsoft.EntityFrameworkCore;
using GestionApp.Data;

namespace GestionApp.Models
{
    public class SeedProfesor
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GestionAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GestionAppContext>>()
                ))
            {
                //EN CASO DE CONTEXTO NULO TIENE UN ERROR.
                if (context == null || context.Profesor == null)
                {
                    throw new ArgumentException("NULL GestionAppContext");
                }

                if (context.Profesor.Any())
                {
                    //LA BASE DE DATOS RETORNA TODO LO QUE CONTIENE ESTA CLASE
                    return;
                }

                context.Profesor.AddRange(
                    new Profesor
                    {
                        NombreProfesor = "Bertha",
                        ApellidoProfesor = "Bravo",
                        MatriculaProfesor = 15000543
                    },
                    new Profesor
                    {
                        NombreProfesor = "Armando",
                        ApellidoProfesor = "Gonzales",
                        MatriculaProfesor = 15000815
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
