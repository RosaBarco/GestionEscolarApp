using Microsoft.EntityFrameworkCore;
using GestionApp.Data;
using GestionEscolarApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GestionApp.Models
{
    public class SeedCalificacion
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GestionAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GestionAppContext>>()
                ))
            {
                //EN CASO DE CONTEXTO NULO TIENE UN ERROR.
                if (context == null || context.Calificacion == null)
                {
                    throw new ArgumentException("NULL GestionAppContext");
                }

                if (context.Calificacion.Any())
                {
                    //LA BASE DE DATOS RETORNA TODO LO QUE CONTIENE ESTA CLASE
                    return;
                }

                context.Calificacion.AddRange(
                    new Calificacion
                    {
                        IdMateria = 1,
                        IdAlumno = 1,
                        nota = 10
                    },
                    new Calificacion
                    {
                        IdMateria = 1,
                        IdAlumno = 2,
                        nota = 8
                    },
                    new Calificacion
                    {
                        IdMateria = 1,
                        IdAlumno = 3,
                        nota = 9
                    },
                    new Calificacion
                    {
                        IdMateria = 2,
                        IdAlumno = 1,
                        nota = 9
                    },
                    new Calificacion
                    {
                        IdMateria = 2,
                        IdAlumno = 2,
                        nota = 7
                    },
                    new Calificacion
                    {
                        IdMateria = 2,
                        IdAlumno = 3,
                        nota = 6
                    },
                    new Calificacion
                    {
                        IdMateria = 3,
                        IdAlumno = 1,
                        nota = 9
                    },
                    new Calificacion
                    {
                        IdMateria = 3,
                        IdAlumno = 2,
                        nota = 10
                    },
                    new Calificacion
                    {
                        IdMateria = 3,
                        IdAlumno = 3,
                        nota = 8
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
