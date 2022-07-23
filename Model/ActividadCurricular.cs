using System;


namespace Model {

  /// <summary>
  /// Este tipo de actividad se refiere a aquellas que cuentan con cursos y docentes, a demás su redención solo se considera cuando se obtiene el certificado de culminación o título
  /// </summary>
  public class ActividadCurricular : Actividad {
    /// <summary>
    /// Fecha en la que se inicia el periodo de la actividad.
    /// </summary>
    private DateTime _fechaInicio;
    /// <summary>
    /// Fecha en la que culmina el periodo de la actividad.
    /// </summary>
    private DateTime _fechaFin;
    /// <summary>
    /// Número de días de condena que se reducen si el preso culmina la aactividad.
    /// </summary>
    private int _remisionTotal;

    public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
    public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }
    public int RemisionTotal { get => _remisionTotal; set => _remisionTotal = value; }

    public ActividadCurricular() { }
    public ActividadCurricular(int cupos, string descripcion, string modalidad, int remisionTotal, DateTime fechaInicio, DateTime fechaFin) : base(cupos, descripcion, modalidad) {
      this._fechaInicio = fechaInicio;
      this._fechaFin = fechaFin;
      this._remisionTotal = remisionTotal;
    }
    public ActividadCurricular(int id, int cupos, string descripcion, string modalidad, int remisionTotal, DateTime fechaInicio, DateTime fechaFin) : base(cupos, descripcion, modalidad) {
      this._fechaInicio = fechaInicio;
      this._fechaFin = fechaFin;
      this._remisionTotal = remisionTotal;
    }
  }
}
