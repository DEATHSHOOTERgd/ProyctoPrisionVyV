namespace Model {

  /// <summary>
  /// Estas actividades consisten en trabajos que los presos realizan dentro de la prisión y su redención se aplica cada día de trabajo culminado.
  /// </summary>
  public class ActividadPractica : Actividad {
    /// <summary>
    /// Horas que se reducen de la condena por cada día laborado.
    /// </summary>
    private int _remisionDiaria;

    public int RemisionDiaria { get => _remisionDiaria; set => _remisionDiaria = value; }
    public ActividadPractica(int cupos, string descripcion, string modalidad, int remisionDiaria) : base(cupos, descripcion, modalidad) {
      this._remisionDiaria = remisionDiaria;
    }
    public ActividadPractica(int id, int cupos, string descripcion, string modalidad, int remisionDiaria) : base(id, cupos, descripcion, modalidad) {
      this._remisionDiaria = remisionDiaria;
    }
    public ActividadPractica() { }
  }
}
