using System.Collections.Generic;


namespace Model {

  /// <summary>
  /// Horario planificado para una actividad o equipo de trabajo.
  /// </summary>
  public class Horario {
    /// <summary>
    /// Lista de jornadas del horario.
    /// </summary>
    private List<Jornada> _jornadas;

    public List<Jornada> Jornadas { get => _jornadas; set => _jornadas = value; }

    public Horario(List<Jornada> jornadas) {
      this._jornadas = jornadas;
    }
  }
}
