using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPartners2.Cap5;

namespace DesignPartners2.Cap4
{
  public interface IExpressao
  {
    int Avalia();
    void Aceita(IVisitor impressora);
  }
}
