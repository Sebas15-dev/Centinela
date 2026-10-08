using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Acudiente : Persona
    {
        public string parentezco { get; set; }

        public List<Estudiante> estudiantes { get; set; }

        public Acudiente(string documento, string nombre, string telefono, string correo, string parentezco, List<Estudiante> estudiantes) : base(documento, nombre, telefono, correo)
        {
            this.parentezco = parentezco;
            this.estudiantes = estudiantes; 
        }
    }
}
