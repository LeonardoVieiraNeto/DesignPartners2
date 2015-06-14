using DesignPartners2.Cap8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap9
{
  public class ClienteDAO
  {
    public Cliente BuscaPorCpf(string cpf)
    {
      Cliente cliente = new Cliente();
      cliente.Nome = "Leo";
      cliente.Endereco = "Endereço";
      cliente.DataNascimento = DateTime.Now.AddYears(-10);

      return cliente;
    }
  }
}
