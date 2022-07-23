namespace Model {

  /// <summary>
  /// Clasificación de un usuraio según sus responsabilidades y permisos.
  /// </summary>
  public class Rol {
    /// <summary>
    /// Es el identificador del rol dado por la BD.
    /// </summary>
    private int _id;
    /// <summary>
    /// Nombre del cargo o rol.
    /// </summary>
    private string _descripcion;

    public int Id { get => _id; set => _id = value; }
    public string Descripcion { get => _descripcion; set => _descripcion = value; }

    public Rol(int id, string descripcion) {
      this._id = id;
      this._descripcion = descripcion;
    }

    public Rol() {
    }

    public Rol(string descripcion) {
      this._descripcion = descripcion;
    }
  }
}
