using System.Collections.Generic;


namespace Model {

  /// <summary>
  /// Es el expediente de un recluso son su código y lista de cargos vigentes, por los cuale se encuentra cumpliendo condena.
  /// </summary>
  public class Expediente {
    /// <summary>
    /// Es el identificador del expediente dado por la BD.
    /// </summary>
    private int _id;
    /// <summary>
    /// Es el código de expediente dado por las autoridades encargadas.
    /// </summary>
    private string _codigo;
    /// <summary>
    /// Lista de cargos que ha tenido el recluso.
    /// </summary>
    private List<Cargo> _cargos;
    /// <summary>
    /// Sentencia total en días por los cargos vigentes.
    /// </summary>
    private int _condenaTotalDias;

    public string Codigo { get => _codigo; set => _codigo = value; }
    public List<Cargo> Cargos { get => _cargos; set => _cargos = value; }
    public int CondenaTotalDias { get => _condenaTotalDias; set => _condenaTotalDias = value; }
    public int Id { get => _id; set => _id = value; }

    public Expediente(int id, string codigo, List<Cargo> cargos, int condenaTotalDias) {
      this._id = id;
      this._codigo = codigo;
      this._cargos = cargos;
      this._condenaTotalDias = condenaTotalDias;
    }
    public Expediente(int id, string codigo) {
      this._id = id;
      this._codigo = codigo;
    }
    public Expediente() {

    }
  }
}
