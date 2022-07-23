using System;


namespace Model {

  /// <summary>
  /// Horario diario contemplado para cierta actividad.
  /// </summary>
  public class Jornada {
    /// <summary>
    /// Día d ela semana
    /// </summary>
    private string _dia;
    /// <summary>
    /// Hora de inicio de actividades.
    /// </summary>
    private DateTime _horaInicio;
    /// <summary>
    /// Hora a la que se finalizan las actividades.
    /// </summary>
    private DateTime _horaFin;

    public string Dia { get => _dia; set => _dia = value; }
    public DateTime HoraInicio { get => _horaInicio; set => _horaInicio = value; }
    public DateTime HoraFin { get => _horaFin; set => _horaFin = value; }

    public Jornada(string dia, DateTime horaInicio, DateTime horaFin) {
      this._dia = dia;
      this._horaInicio = horaInicio;
      this._horaFin = horaFin;
    }
  }
}
