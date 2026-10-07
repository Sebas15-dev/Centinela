using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        public string especialidad { get; set; }
        public Profesor(string documento, string nombre, string telefono, string correo, string especialidad) : base(documento, nombre, telefono, correo)
        {
            this.especialidad = especialidad;
        }
    }
}
