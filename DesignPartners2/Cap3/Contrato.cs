using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap3
{
  public class Contrato
  {
    public DateTime Data { get; private set; }

    public String Cliente { get; private set; }

    public TipoContrato Tipo { get; private set; }

    public Contrato(DateTime data, string cliente, TipoContrato tipoContrato)
    {
      this.Data = data;
      this.Cliente = Cliente;
      this.Tipo = tipoContrato;
    }

    public void Avanca()
    {
      if (this.Tipo == TipoContrato.Novo)
        this.Tipo = TipoContrato.Endamento;
      else if (this.Tipo == TipoContrato.Endamento)
        this.Tipo = TipoContrato.Acertado;
      else if (this.Tipo == TipoContrato.Acertado)
        this.Tipo = TipoContrato.Concluido;
    }

    public Estado SalvaEstado()
    {
      return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
    }
  }
}
