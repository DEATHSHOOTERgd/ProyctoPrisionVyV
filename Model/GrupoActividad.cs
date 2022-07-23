using System.Collections.Generic;


namespace Model {

  /// <summary>
  /// Representa  aun grupo de reclusos que participan en una actividad y el horario en el que la desarrollan.
  /// </summary>
  public abstract class GrupoActividad {
    /// <summary>
    /// Lista de reclusos que participan en la actividad.
    /// </summary>
    private List<Recluso> _reclusos;
    /// <summary>
    /// Horario en el que se desarrolla la actividad.
    /// </summary>
    private Horario _horario;
    /// <summary>
    /// Actividad que realiza el grupo.
    /// </summary>
    private Actividad _actividad;

    public List<Recluso> Reclusos { get => _reclusos; set => _reclusos = value; }
    public Horario Horario { get => _horario; set => _horario = value; }
    public Actividad Actividad { get => _actividad; set => _actividad = value; }

    protected GrupoActividad(List<Recluso> reclusos, Horario horario, Actividad actividad) {
      this._reclusos = reclusos;
      this._horario = horario;
      this._actividad = actividad;
    }
  }
}
