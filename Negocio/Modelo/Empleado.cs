
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelo {
    public class Empleado {
        public Empleado() { }

        public Empleado(DataAccess.Tablas.Empleado empleado) {
            Id = empleado.Id;
            PersonaId = empleado.PersonaId;
            FechaContratacion = empleado.FechaContratacion;
            FechaCreacion = empleado.FechaCreacion;
            Salario = empleado.Salario;
            RolId = empleado.RolId;
            Correo = empleado.Correo;
            Telefono = empleado.Telefono;
            SedeId = empleado.SedeId;
            Sede = new Sede(empleado.SEDES);
            Rol = new Rol(empleado.ROLES);
            Persona = new Persona(empleado.PERSONAS);
        }
        public decimal Id { get; set; }
        public decimal PersonaId { get; set; }
        public DateTime FechaContratacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal Salario { get; set; }
        public decimal RolId { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public decimal SedeId { get; set; }

        public Sede Sede { get; set; }
        public Rol Rol { get; set; }
        public Persona Persona { get; set; }

        public DataAccess.Tablas.Empleado Convertir() {
            return new DataAccess.Tablas.Empleado {
            Id = Id,
            PersonaId = PersonaId,
            FechaContratacion = FechaContratacion,
            FechaCreacion = FechaCreacion,
            Salario = Salario,
            RolId = RolId,
            Correo = Correo,
            Telefono = Telefono,
            SedeId = SedeId,
        };
        }
    }
}
