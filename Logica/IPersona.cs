using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IPersona <T>
    {
        string Guardar(T entidad);
        bool Actualizar(T entidad);
        string Eliminar(string documento);
        List<T> Consultar();
        T BuscarPorDocumento(string documento);
    }
}
