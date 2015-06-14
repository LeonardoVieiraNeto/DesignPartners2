using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap7
{
  public class Pedido
  {
    public string Cliente { get; set; }

    public double Valor { get; set; }

    public DateTime DataFinalizacao { get; set; }

    public Status Status { get; set; }

    public Pedido(string _cliente, double _valor)
    {
      this.Cliente = _cliente;
      this.Valor = _valor;
      this.Status = Status.Novo;
    }

    public void Paga()
    {
      Status = Status.Pago;
    }

    public void Finaliza()
    {
      Status = Status.Entregue;
      this.DataFinalizacao = DateTime.Now;
    }
  }
}
