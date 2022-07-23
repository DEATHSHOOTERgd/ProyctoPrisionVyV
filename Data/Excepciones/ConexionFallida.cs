using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Excepciones
{
    public class ConexionFallida : Exception
    {
        string mensaje;
        public ConexionFallida()
        {
            this.mensaje = "No se pudo establecer conexión con la base de datos.";
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
