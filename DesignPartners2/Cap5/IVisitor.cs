using DesignPartners2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap5
{
  //Para criar outra classe Visitor bastaria implementar os métodos dessa interface.
  public interface IVisitor
  {
    void ImprimeSoma(Soma soma);
    void ImprimeSubtracao(Subtracao subtracao);
    void ImprimeNumero(Numero numero);
    void ImprimeMultiplicacao(Multiplicacao multiplicao);
    void ImprimeDivisao(Divisao divisao);
    void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);
  }
}
