using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPartners2.Cap9
{
  public class Cobranca
  {
    private Tipo Tipo;
    private Fatura Fatura;

    public Cobranca(Tipo tipo, Fatura fatura)
    {
      Tipo = tipo;
      Fatura = fatura;
    }

    public void Emite()
    {

    }
  }
}
