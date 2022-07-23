using System;

namespace Control {
  public class GeneralExcepcion : Exception {
    String message;
    public GeneralExcepcion(String message) : base(message) {
      this.message = message;
    }
  }

}
