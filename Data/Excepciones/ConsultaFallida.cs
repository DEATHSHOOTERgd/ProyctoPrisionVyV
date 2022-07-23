﻿using System;

namespace Data.Excepciones {
  public class ConsultaFallida : Exception {
    string mensaje;
    public ConsultaFallida() {
      this.mensaje = "La consulta a la base de datos falló y por ende no devolvió lso resultados esperados.";
    }

    public string Mensaje { get => mensaje; set => mensaje = value; }
  }
}
