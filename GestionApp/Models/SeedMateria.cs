using Microsoft.EntityFrameworkCore;
using GestionApp.Data;
using GestionEscolarApp.Models;

namespace GestionApp.Models
{
    public class SeedMateria
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GestionAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GestionAppContext>>()
                ))
            {
                //EN CASO DE CONTEXTO NULO TIENE UN ERROR.
                if (context == null || context.Materia == null)
                {
                    throw new ArgumentException("NULL GestionAppContext");
                }

                if (context.Materia.Any())
                {
                    //LA BASE DE DATOS RETORNA TODO LO QUE CONTIENE ESTA CLASE
                    return;
                }

                context.Materia.AddRange(
                    new Materia
                    {
                        NombreMateria = "Matemáticas para ingeniería"
                    },
                    new Materia
                    {
                        NombreMateria = "Sistemas computacionales"
                    },
                    new Materia
                    {
                        NombreMateria = "Base de datos avanzadas"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
