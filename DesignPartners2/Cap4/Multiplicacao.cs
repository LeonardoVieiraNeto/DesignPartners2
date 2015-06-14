using DesignPartners2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap4
{
  public class Multiplicacao : IExpressao
  {
    public IExpressao Esquerda { get; private set; }
    public  IExpressao Direita { get; private set; }

    public Multiplicacao(IExpressao esquerda, IExpressao direita)
    {
      this.Esquerda = esquerda;
      this.Direita = direita;
    }

    public int Avalia()
    {
      //Recupera o resultado da expressão da esquerda
      int valorEsquerda = Esquerda.Avalia();

      //Recupera o resultado da expressão da direita
      int valorDireita = Direita.Avalia();

      return valorEsquerda * valorDireita;
    }

    public void Aceita(IVisitor impressora)
    {
      impressora.ImprimeMultiplicacao(this);
    }
  }
}
