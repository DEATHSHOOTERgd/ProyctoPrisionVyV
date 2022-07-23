using System.Collections.Generic;


namespace Model {

  /// <summary>
  /// Es el grupo de trabajo que participa en una actividad práctica.
  /// </summary>
  public class EquipoTrabajo : GrupoActividad {
    /// <summary>
    /// Razón matemática en la que se redime la condena. Ejemplo: 0.5= Medio día de condena menos por día laborado.
    /// </summary>
    private float _razonDiariaRedencion;

    public EquipoTrabajo(List<Recluso> reclusos, Horario horario, Actividad actividad, float razonDiariaRedencion) : base(reclusos, horario, actividad) {
      this._razonDiariaRedencion = razonDiariaRedencion;
    }
  }
}
