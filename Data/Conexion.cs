using Data.Excepciones;
using System;
using System.Data.SqlClient;


namespace Data {

  /// <summary>
  /// Es la clase que se encarga de establecer la conexión entre la aplicación y la base de datos.
  /// </summary>
  public class Conexion {
    /// <summary>
    /// Es la cadena de conexión , contiene las credenciales y la dirección del servidor de base de datos necesarias para establecer la conexión.
    /// </summary>
    private static string _cadena = "Data Source=sql5059.site4now.net;Initial Catalog=db_a7961c_prision2p;Persist Security Info=True;User ID=db_a7961c_prision2p_admin;Password=prision123";
    /// <summary>
    /// Es la instancia de conexión del programa con la base de datos. 
    /// </summary>
    private SqlConnection _conexion = null;
    public SqlConnection _Conexion { get => _conexion; set => _conexion = value; }
    /// <summary>
    /// Abre la conexión con la base de datos.
    /// </summary>
    public void Conectar() {

      try {
        _Conexion = new SqlConnection();
        _Conexion.ConnectionString = _cadena;
        _Conexion.Open();
      } catch (SqlException) {

        throw new ConexionFallida();
      }
    }
    /// <summary>
    /// Cierra la conexión con la base de datos.
    /// </summary>
    /// <returns>Devuelve "1" si la conexión se cerró con éxito y un "0" seguido de el mensage de error si exitió algún error al intentar cerrarla.</returns>
    public string Cerrar() {
      string x = "";

      try {
        _Conexion.Close();
        x = "1";
      } catch (Exception ex) {

        Console.WriteLine(ex.Message);
        x = "0" + ex.Message;
      }
      return x;
    }
  }
}
