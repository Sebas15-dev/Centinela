using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        public string idAsistencia { get; set; }
        public DateTime Fecha{ get; set; }
        public string estado { get; set; }
        public Estudiante estudiante{ get; set; }
        public Clase clase { get; set; }

        public Asistencia(string idAsistencia, DateTime fecha, string estado, Estudiante estudiante, Clase clase)
        {
            this.idAsistencia = idAsistencia;
            Fecha = fecha;
            this.estado = estado;
            this.estudiante = estudiante;
            this.clase = clase;
        }
    }
}
