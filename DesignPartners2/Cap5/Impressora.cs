using DesignPartners2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap5
{
  public class Impressora : IVisitor
  {
    public void ImprimeSoma(Soma soma)
    {
      Console.Write("(");
      soma.Esquerda.Aceita(this);
      Console.Write("+");

      soma.Direita.Aceita(this);
      Console.Write(")");
    }

    public void ImprimeSubtracao(Subtracao subtracao)
    {
      Console.Write("(");
      subtracao.Esquerda.Aceita(this);
      Console.Write("-");
      subtracao.Direita.Aceita(this);
      Console.Write(")");
    }

    public void ImprimeMultiplicacao(Multiplicacao multiplicao)
    {
      Console.Write("(");
      multiplicao.Esquerda.Aceita(this);
      Console.Write("*");
      multiplicao.Direita.Aceita(this);
      Console.Write(")");
    }

    public void ImprimeDivisao(Divisao divisao)
    {
      Console.Write("(");
      divisao.Esquerda.Aceita(this);
      Console.Write("/");
      divisao.Esquerda.Aceita(this);
      Console.Write(")");
    }

    public void ImprimeNumero(Numero numero)
    {
      Console.Write(numero.Valor);
    }

    public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
    {
      
    }
  }
}
