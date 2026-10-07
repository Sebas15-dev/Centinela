using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public string idCurso { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }
        public List<Estudiante> estudiantes { get; set; }

        public Curso(string idCurso, string grado, string grupo, List<Estudiante> estudiantes)
        {
            this.idCurso = idCurso;
            this.grado = grado;
            this.grupo = grupo;
            this.estudiantes = estudiantes;
        }

    }
}
