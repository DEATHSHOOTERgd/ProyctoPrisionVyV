using System;

namespace Model {

  /// <summary>
  /// Cargo penal por el cual el preso está cumpliendo sentencia.
  /// </summary>
  public class Cargo {
    /// <summary>
    /// Nombre o descrípción del cargo penal.
    /// </summary>
    private string _descripcion;
    /// <summary>
    /// Delito tipificado que se cometió.
    /// </summary>
    private string _delito;
    /// <summary>
    /// Es el identificador del cargo dado por la BD.
    /// </summary>
    private int _id;
    /// <summary>
    /// Lugar donde se cometió el delito o crimen.
    /// </summary>
    private Lugar _lugarHechos;
    /// <summary>
    /// Fecha en la que se cometió el delito o crimen.
    /// </summary>
    private DateTime _fechaHechos;

    public string Descripcion { get => _descripcion; set => _descripcion = value; }
    public string Delito { get => _delito; set => _delito = value; }
    public int Id { get => _id; set => _id = value; }
    public Lugar LugarHechos { get => _lugarHechos; set => _lugarHechos = value; }
    public DateTime FechaHechos { get => _fechaHechos; set => _fechaHechos = value; }

    public Cargo(string descripcion, string delito, int id, Lugar lugarHechos, DateTime fechaHechos) {
      this._descripcion = descripcion;
      this._delito = delito;
      this._id = id;
      this._lugarHechos = lugarHechos;
      this._fechaHechos = fechaHechos;
    }
    public Cargo() { }

  }
}
