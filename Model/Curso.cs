using System.Collections.Generic;


namespace Model {

  /// <summary>
  /// Es un curso asignado a de una actividad curricular
  /// </summary>
  public class Curso : GrupoActividad {
    /// <summary>
    /// Total de días de redención que se aplicna al finalizar el curso 
    /// </summary>
    private int _totalDiasRedencion;
    /// <summary>
    /// Número de días que dura el curso.
    /// </summary>
    private int _diasDuracion;

    public int TotalDiasRedencion { get => _totalDiasRedencion; set => _totalDiasRedencion = value; }
    public int DiasDuracion { get => _diasDuracion; set => _diasDuracion = value; }

    public Curso(List<Recluso> reclusos, Horario horario, Actividad actividad, int totalDiasRedencion, int diasDuracion) : base(reclusos, horario, actividad) {
      this._totalDiasRedencion = totalDiasRedencion;
      this._diasDuracion = diasDuracion;
    }
  }
}
