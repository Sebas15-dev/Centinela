using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante : Persona
    {
        public string estado{ get; set; }
        public Acudiente acudiente{ get; set; }
        public Curso curso{ get; set; }

        public Estudiante(string documento, string nombre, string telefono, string correo, string estado, Acudiente acudiente, Curso curso) : base(documento, nombre, telefono, correo)
        {
            this.estado = estado;
            this.acudiente = acudiente;
            this.curso = curso;
        }
    }
}
