using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap7
{
  public class FilaDeTrabalho
  {
    private IList<IComando> Comandos = new List<IComando>();

    public void Adiciona(IComando comando)
    {
      this.Comandos.Add(comando);
    }

    public void Processa()
    {
      foreach(var comando in Comandos)
      {
        comando.Executa();
      }
    }
  }
}
