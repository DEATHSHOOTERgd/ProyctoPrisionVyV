namespace Model {
  /// <summary>
  /// Esta es la clase padre que representa las actividades en las que se pueden inscribir los reclusos dentro de la prisión.
  /// </summary>
  public abstract class Actividad {
    /// <summary>
    /// Es el identificador de la actividad dado por la BD.
    /// </summary>
    private int _id;
    /// <summary>
    /// Es el número de cupos disponiles para una actividad.
    /// </summary>
    private int _cupos;
    /// <summary>
    /// Es el nombre de la actividad o descripción de la misma.
    /// </summary>
    private string _descripcion;
    /// <summary>
    /// Es la modalidad en la que se realiza la actividad
    /// </summary>
    private string _modalidad;

    public int Id { get => _id; set => _id = value; }
    public int Cupos { get => _cupos; set => _cupos = value; }
    public string Descripcion { get => _descripcion; set => _descripcion = value; }
    public string Modalidad { get => _modalidad; set => _modalidad = value; }

    public Actividad(int id, int cupos, string descripcion, string modalidad) {
      this._cupos = cupos;
      this._descripcion = descripcion;
      this._modalidad = modalidad;

    }

    public Actividad(int cupos, string descripcion, string modalidad) {
      this._cupos = cupos;
      this._descripcion = descripcion;
      this._modalidad = modalidad;
    }
    public Actividad() { }



  }
}
