using System;


namespace Model {

  /// <summary>
  /// Registrio de la inscripción de un recluos en una actividad.
  /// </summary>
  class Inscripcion {
    /// <summary>
    /// Es el identificador de la inscripción dado por la BD.
    /// </summary>
    private int _id;
    /// <summary>
    /// Recluso inscrito.
    /// </summary>
    private Recluso _recluso;
    /// <summary>
    /// Actiovidad en la que se inscribe..
    /// </summary>
    private Actividad _actividad;
    /// <summary>
    /// Fecha de la inscripción.
    /// </summary>
    private DateTime _fecha;
    /// <summary>
    /// Cófigo identificador de la incripción.
    /// </summary>
    private int _codigoInscripcion;

    public int Id { get => _id; set => _id = value; }
    public Recluso Recluso { get => _recluso; set => _recluso = value; }
    public Actividad Actividad { get => _actividad; set => _actividad = value; }
    public DateTime Fecha { get => _fecha; set => _fecha = value; }
    public int CodigoInscripcion { get => _codigoInscripcion; set => _codigoInscripcion = value; }

    public Inscripcion() {}

    public Inscripcion(int id, Recluso recluso, Actividad actividad, DateTime fecha, int codigoInscripcion) {
      this._id = id;
      this._recluso = recluso;
      this._actividad = actividad;
      this._fecha = fecha;
      this._codigoInscripcion = codigoInscripcion;
    }
  }
}
