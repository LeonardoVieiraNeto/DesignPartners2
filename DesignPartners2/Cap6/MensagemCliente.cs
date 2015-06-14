using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap6
{
  public class MensagemCliente : IMensagem
  {
    private string nome;
    public IEnviador Enviador { get; set; }

    public MensagemCliente(string nome)
    {
      this.nome = nome;
    }

    public void Envia()
    {
      this.Enviador.Envia(this);
    }

    //Devolve a string formatada para envio do SMS
    public string Formata()
    {
      return string.Format("Mensagem para o cliente: {0}", nome);
    }
  }
}
