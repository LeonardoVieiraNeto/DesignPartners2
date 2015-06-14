using DesignPartners2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap5
{
  //Na impressora Pré Fixa o sinal da expressão fica fixo sempre a esquerda da expressão
  public class ImpressoraPreFixa : IVisitor
  {
    public void ImprimeSoma(Soma soma)
    {
      Console.Write("+");
      
      Console.Write("(");
      soma.Esquerda.Aceita(this);

      soma.Direita.Aceita(this);
      Console.Write(")");
    }

    public void ImprimeSubtracao(Subtracao subtracao)
    {
      Console.Write("-");
      
      Console.Write("(");
      subtracao.Esquerda.Aceita(this);
      
      subtracao.Direita.Aceita(this);
      Console.Write(")");
    }

    public void ImprimeMultiplicacao(Multiplicacao multiplicao)
    {
      Console.Write("*");
      
      Console.Write("(");
      multiplicao.Esquerda.Aceita(this);
     
      multiplicao.Direita.Aceita(this);
      Console.Write(")");
    }

    public void ImprimeDivisao(Divisao divisao)
    {
      Console.Write("/");

      Console.Write("(");
      divisao.Esquerda.Aceita(this);
      
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
