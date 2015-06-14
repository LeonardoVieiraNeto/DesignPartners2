using DesignPartners2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap4
{
  public class Numero : IExpressao
  {
    public int Valor {get; private set;}

    public Numero(int valor)
    {
      this.Valor = valor;
    }

    public int Avalia()
    {
      return Valor;
    }

    public void Aceita(IVisitor impressora)
    {
      impressora.ImprimeNumero(this);
    }
  }
}
