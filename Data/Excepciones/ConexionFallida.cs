using System;

namespace Data.Excepciones {
  public class ConexionFallida : Exception {
    string mensaje;
    public ConexionFallida() {
      this.mensaje = "No se pudo establecer conexión con la base de datos.";
    }

    public string Mensaje { get => mensaje; set => mensaje = value; }
  }
}
