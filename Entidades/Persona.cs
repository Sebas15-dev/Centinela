using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected Persona(string documento, string nombre, string telefono, string correo)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }

        public String documento { get; set; }
        public String nombre { get; set; }
        public String telefono { get; set; }
        public String correo { get; set; }

    }
}
