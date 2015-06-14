using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap9
{
  public class EmpresaFacadeSingleton
  {
    private static EmpresaFacade empresaFacade = new EmpresaFacade();

    public EmpresaFacade Instancia
    {
      get
      {
        return empresaFacade;
      }
    }
  }
}
