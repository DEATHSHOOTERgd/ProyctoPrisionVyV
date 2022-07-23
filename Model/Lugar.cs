namespace Model {

  /// <summary>
  /// Ubicación geográfica.
  /// </summary>
  public class Lugar {
    /// <summary>
    /// Nombre de la localidad o nombre por la que se la conoce. Ejemplo: Barrio Chorrillo. 
    /// </summary>
    private string _nombreLocalidad;
    /// <summary>
    /// Nombre de la ciudad. Ejemplo: San Cristóbal. 
    /// </summary>
    private string _nombreCiudad;
    /// <summary>
    /// Nombre del país. Ejemplo: Colombia. 
    /// </summary>
    private string _nombrePais;

    public string NombreLocalidad { get => _nombreLocalidad; set => _nombreLocalidad = value; }
    public string NombreCiudad { get => _nombreCiudad; set => _nombreCiudad = value; }
    public string NombrePais { get => _nombrePais; set => _nombrePais = value; }
  }
}
