using DesignPartners2.Cap8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap9
{
  public class EmpresaFacade
  {
    public Cliente BuscaCliente(string cpf)
    {
      return new ClienteDAO().BuscaPorCpf(cpf);
    }

    public Fatura CriarFatura(Cliente cliente, double valor)
    {
      return new Fatura(cliente, valor);
    }

    public void GeraCobranca(Tipo tipo, Fatura fatura)
    {
      Cobranca cobranca = new Cobranca(tipo, fatura);
      cobranca.Emite();
    }

    public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
    {
      ContatoCliente contato = new ContatoCliente(cliente, cobranca);
      contato.Dispara();
      return contato;
    }
  }
}
