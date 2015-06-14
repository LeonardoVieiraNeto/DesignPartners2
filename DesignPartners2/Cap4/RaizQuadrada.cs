using DesignPartners2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap4
{
  public class RaizQuadrada : IExpressao
  {
    public IExpressao expressao { get; private set; }

    public RaizQuadrada(IExpressao e)
    {
      this.expressao = e;
    }

    public int Avalia()
    {
      return (int)Math.Sqrt(expressao.Avalia());
    }

    public void Aceita(IVisitor impressora)
    {
      impressora.ImprimeRaizQuadrada(this);
    }
  }
}
