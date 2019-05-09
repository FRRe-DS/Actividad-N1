using EfCodeFirstCliente.Models;
using System;
using System.Linq;

namespace EfCodeFirstCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "edgardo" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            using (var context = new SchoolContext())
            {
                var NombreEstudiante = context.Students
                                                  .Where(s => s.StudentName == "Mariano")
                                                  .Select(s => s.StudentID)
                                                  .ToList();

                foreach (var Nombre in NombreEstudiante)
                {
                    Console.WriteLine($"{Nombre}");
                }
            }
            
        }
    }
    
}
