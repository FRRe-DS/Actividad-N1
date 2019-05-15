using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace proyecto.Models
{
    public class TurnosContext : DbContext
    {
        public TurnosContext(DbContextOptions<TurnosContext> options)
            : base(options)
        { }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
    }

    public class Medico
    {
        public int medicoId { get; set; }
        public string nombre { get; set; }
        
        public string especialidad { get; set; }


        public List<Paciente> Pacientes  { get; set; }
    }

    public class Paciente
    {
        public int pacienteId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public int medicoId { get; set; }
        public Medico medico { get; set; }
    }
}