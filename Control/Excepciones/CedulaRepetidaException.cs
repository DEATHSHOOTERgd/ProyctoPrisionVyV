using System;

namespace Control.Excepciones {
  public class CedulaRepetidaException : Exception {
    string mensaje;
    public CedulaRepetidaException() {
      this.mensaje = "Ya existe un recluso registrado con esa cédula.";
    }

    public string Mensaje { get => mensaje; set => mensaje = value; }
  }
}
