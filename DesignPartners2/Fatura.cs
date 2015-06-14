using DesignPartners2.Cap8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPartners2
{
  public class Fatura
  {
    private Cliente Cliente;
    private double Valor;

    public Fatura(Cliente cliente, double valor)
    {
      Cliente = cliente;
      Valor = valor;
    }
  }
}
