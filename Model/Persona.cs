using System;


namespace Model {

  /// <summary>
  /// Almacena los datos personales tanto de usuarios como presos. 
  /// </summary>
  public abstract class Persona {
    /// <summary>
    /// Es el identificador de la actividad dado por la BD.
    /// </summary>
    private int _id;
    /// <summary>
    /// Nombres de la personas
    /// </summary>
    private string _nombre;
    /// <summary>
    /// Apellidos de la personas
    /// </summary>
    private string _apellidos;
    /// <summary>
    /// Género de la personas
    /// </summary>
    private string _genero;
    /// <summary>
    /// Fecha de nacimiento de la persona
    /// </summary>
    private DateTime _fecha;
    /// <summary>
    /// Número de cédula de la persona
    /// </summary>
    private string _cedula;

    public string Nombre { get => _nombre; set => _nombre = value; }
    public string Apellidos { get => _apellidos; set => _apellidos = value; }
    public string Genero { get => _genero; set => _genero = value; }
    public DateTime Fecha { get => _fecha; set => _fecha = value; }
    public int Id { get => _id; set => _id = value; }
    public string Cedula { get => _cedula; set => _cedula = value; }

    public Persona(string codigo, string nombre, string apellidos, string genero, DateTime fecha, string cedula) {
      this._nombre = nombre;
      this._apellidos = apellidos;
      this._genero = genero;
      this._fecha = fecha;
      this._cedula = cedula;
    }

    public Persona() { }

    public Persona(int id, string codigo, string nombre, string apellidos, string genero, DateTime fecha, string cedula) {
      this._nombre = nombre;
      this._apellidos = apellidos;
      this._genero = genero;
      this._fecha = fecha;
      this._cedula = cedula;
    }
  }
}
