using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap7
{
  public class FinalizaPedido : IComando
  {
    private Pedido Pedido { get; set; }

    public FinalizaPedido(Pedido pedido)
    {
      this.Pedido = pedido;
    }

    public void Executa()
    {
      Console.WriteLine("Finalizando o pedido do cliente {0}", Pedido.Cliente);
      this.Pedido.Finaliza();
    }
  }
}
