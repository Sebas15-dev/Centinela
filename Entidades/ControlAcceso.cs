using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ControlAcceso
    {
        public int IdAcceso { get; set; }
        public DateTime FechaHora { get; set; }
        public string TipoRegistro { get; set; }
        public Estudiante Estudiante { get; set; }

        public ControlAcceso(int idAcceso, DateTime fechaHora, string tipoRegistro, Estudiante estudiante)
        {
            IdAcceso = idAcceso;
            FechaHora = fechaHora;
            TipoRegistro = tipoRegistro;
            Estudiante = estudiante;
        }
    }
}
