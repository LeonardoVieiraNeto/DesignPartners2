using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap6
{
  public class MensagemAdministrativa : IMensagem
  {
    private string nome;
    public IEnviador Enviador { get; set; }

    public MensagemAdministrativa(string nome)
    {
      this.nome = nome;
    }

    public void Envia()
    {
      this.Enviador.Envia(this);
    }

    //Devolve a string formatada para envio do email
    public string Formata()
    {
      return string.Format("Mensagem para o administrador: {0}", nome);
    }
  }
}
