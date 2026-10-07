using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asignatura
    {
        public string idAsignatura { get; set; }
        public string nombre { get; set; }

        public Asignatura(string idAsignatura, string nombre)
        {
            this.idAsignatura = idAsignatura;
            this.nombre = nombre;
        }
    }
}
