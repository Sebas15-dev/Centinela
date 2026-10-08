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
        private string usuario { get; set; }
        private string contraseñaHash{ get; set; }

        public Profesor(string documento, string nombre, string telefono, string correo, string especialidad, string usuario, string contraseñaHash) : base(documento, nombre, telefono, correo)
        {
            this.especialidad = especialidad;
            this.usuario = usuario;
            this.contraseñaHash = contraseñaHash;
        }
    }
}
