using System;


namespace Model {

  /// <summary>
  /// Almacena los datos de un recluso.
  /// </summary>
  public class Recluso : Persona {
    /// <summary>
    /// Código de recluso dado por la prisión.
    /// </summary>
    private string _codigo;
    /// <summary>
    /// Expediente del recluso por le cual fue internado.
    /// </summary>
    private Expediente _expediente;

    public Expediente Expediente { get => _expediente; set => _expediente = value; }
    public string Codigo { get => _codigo; set => _codigo = value; }

    public Recluso(string nombre, string apellidos, string genero, DateTime fecha, string cedula, string codigo, Expediente expediente) : base(codigo, nombre, apellidos, genero, fecha, cedula) {
      this._expediente = expediente;
      this._codigo = codigo;
    }

    public Recluso() {

    }

    public Recluso(int id, string nombre, string apellidos, string genero, DateTime fecha, string cedula, string codigo, Expediente expediente) : base(id, codigo, nombre, apellidos, genero, fecha, cedula) {
      this._expediente = expediente;
    }
  }
}
