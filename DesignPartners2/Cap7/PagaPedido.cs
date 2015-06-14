using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap7
{
  public class PagaPedido : IComando
  {
    private Pedido Pedido;

    public PagaPedido(Pedido pedido)
    {
      this.Pedido = pedido;
    }

    public void Executa()
    {
      Console.WriteLine("Pagando o pedido do cliente {0}", Pedido.Cliente);
      Pedido.Paga();
    }
  }
}
