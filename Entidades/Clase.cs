using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clase
    {
        public string idClase { get; set; }
        public Curso curso { get; set; }
        public Asignatura asignatura { get; set; }
        public Profesor profesor{ get; set; }

        public Clase(string idClase, Curso curso, Asignatura asignatura, Profesor profesor)
        {
            this.idClase = idClase;
            this.curso = curso;
            this.asignatura = asignatura;
            this.profesor = profesor;
        }

    }
}
