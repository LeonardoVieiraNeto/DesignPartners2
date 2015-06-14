using DesignPartners2.Cap8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPartners2.Cap9
{
  public class ContatoCliente
  {
    private Cliente Cliente;
    private Cobranca Cobranca;

    public ContatoCliente(Cliente cliente, Cobranca cobranca)
    {
      Cliente = cliente;
      Cobranca = cobranca;
    }

    public void Dispara()
    {

    }
  }
}
