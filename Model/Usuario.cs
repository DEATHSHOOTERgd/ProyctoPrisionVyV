namespace Model {

  /// <summary>
  /// Almacena los datos de usuario de la aplicación, incluídas sus credenciales.
  /// </summary>
  /// <remarks>Aquí se encuentran las credenciales de inicio de sesión.</remarks>
  public class Usuario {
    /// <summary>
    /// Es el identificador de la actividad dado por la BD.
    /// </summary>
    private int _id;
    /// <summary>
    /// Nombres del usuario.
    /// </summary>
    private string _nombres;
    /// <summary>
    /// Apellidos del usuario.
    /// </summary>
    private string _apellidos;
    /// <summary>
    /// Nombre de usuario utilizado para el inicio de sesión.
    /// </summary>
    private string _username;
    /// <summary>
    /// Contraseña utilizada para el inicio de sesión.
    /// </summary>
    private string _contrasena;
    private Rol _rol = new Rol();

    public int Id { get => _id; set => _id = value; }
    public string Nombres { get => _nombres; set => _nombres = value; }
    public string Apellidos { get => _apellidos; set => _apellidos = value; }
    public string Username { get => _username; set => _username = value; }
    public string Contrasena { get => _contrasena; set => _contrasena = value; }
    public Rol Rol { get => _rol; set => _rol = value; }

    public Usuario(int id, string nombres, string apellidos, string username, string contrasena, Rol rol) {
      this._id = id;
      this._nombres = nombres;
      this._apellidos = apellidos;
      this._username = username;
      this._contrasena = contrasena;
      this._rol = rol;
    }
    public Usuario() {}
    public Usuario(string nombres, string apellidos, string username, string contrasena, Rol rol) {
      this._nombres = nombres;
      this._apellidos = apellidos;
      this._username = username;
      this._contrasena = contrasena;
      Rol = rol;
    }
  }

}
