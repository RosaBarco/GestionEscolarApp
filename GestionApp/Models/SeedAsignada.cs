using Microsoft.EntityFrameworkCore;
using GestionApp.Data;
using GestionEscolarApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GestionApp.Models
{
    public class SeedAsignada
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GestionAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GestionAppContext>>()
                ))
            {
                //EN CASO DE CONTEXTO NULO TIENE UN ERROR.
                if (context == null || context.Asignada == null)
                {
                    throw new ArgumentException("NULL GestionAppContext");
                }

                if (context.Asignada.Any())
                {
                    //LA BASE DE DATOS RETORNA TODO LO QUE CONTIENE ESTA CLASE
                    return;
                }

                context.Asignada.AddRange(
                    new Asignada
                    {
                        IdMateria = 1,
                        IdProfesor = 1,
                        Horario = "L - 9 a 11, M - 9 a 11",
                        Salon = "D12"
                    },
                    new Asignada
                    {
                        IdMateria = 2,
                        IdProfesor = 2,
                        Horario = "L - 8 a 10, J - 1 a 3, S - 8 a 10",
                        Salon = "Laboratorio de computo 1"
                    },
                    new Asignada
                    {
                        IdMateria = 3,
                        IdProfesor = 2,
                        Horario = "M - 1 a 3, V - 12 a 3",
                        Salon = "Laboratorio de computo 1"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
