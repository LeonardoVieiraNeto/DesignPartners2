using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DesignPartners2.Cap1;
using DesignPartners2.Cap2;
using DesignPartners2.Cap3;
using DesignPartners2.Cap4;
using DesignPartners2.Cap5;
using DesignPartners2.Cap6;
using DesignPartners2.Cap7;
using DesignPartners2.Cap8;
using System.Xml.Serialization;
using System.IO;
using DesignPartners2.Cap9;

namespace DesignPartners2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite a opção desejada: ");
      Console.WriteLine("1 P/ Factory de objetos de conexão");
      Console.WriteLine("2 P/ Piano musical com FlyWeight");
      Console.WriteLine("3 P/ Histórico dos estados de um objeto com Memento");
      Console.WriteLine("4 P/ Calculadora com DSLs e Interpreter");
      Console.WriteLine("5 P/ Calculadora com Estrutura de dados e Visitor");
      Console.WriteLine("6 P/ Enviando e-mail e SMS usando Bridges");
      Console.WriteLine("7 P/ Criar uma fila de trabalho usando o Command");
      Console.WriteLine("8 P/ Simula a integração com um sistema legado usando Adapter");
      Console.WriteLine("9 P/ Façades e Singleton");

      ConsoleKeyInfo caracterDigitado = Console.ReadKey();

      if (caracterDigitado.KeyChar == 49)
      {
        #region Teste para o capitulo 1 - Factory de objetos de conexão

        IDbConnection conexao = new ConnectionFactory().GetConnection();

        IDbCommand comando = conexao.CreateCommand();
        comando.CommandText = "Select * from tabela";

        Console.WriteLine();
        Console.WriteLine("Conexão com banco realizada usando uma factory para criação de objetos de conexão!!!");
        Console.ReadKey();

        #endregion
      }
      else if (caracterDigitado.KeyChar == 50)
      {
        #region Teste para o capitulo 2 - Piano musical com FlyWeight

        NotasMusicais notas = new NotasMusicais();

        IList<INota> musica = new List<INota>()
      {
        notas.Pega("do"),
        notas.Pega("re"),
        notas.Pega("mi"),
        notas.Pega("fa"),

        notas.Pega("fa"),
        notas.Pega("fa")
      };

        Piano piano = new Piano();
        piano.Toca(musica);

        Console.WriteLine();
        Console.WriteLine("Piano executado usando o padrão FlyWeight");
        Console.ReadKey();

        #endregion
      }
      else if (caracterDigitado.KeyChar == 51)
      {
        #region Teste para o capitulo 3 - Histórico dos estados de um objeto com Memento

        Historico historico = new Historico();

        Contrato contrato = new Contrato(DateTime.Now, "Eu", TipoContrato.Novo);
        historico.Adiciona(contrato.SalvaEstado());

        //Avança o contrato para Andamento
        contrato.Avanca();
        historico.Adiciona(contrato.SalvaEstado());

        //Avança o contrato para Endamento

        contrato.Avanca();
        historico.Adiciona(contrato.SalvaEstado());

        //Avança o contrato para Acertado
        contrato.Avanca();
        historico.Adiciona(contrato.SalvaEstado());

        //Avança o contrato para Concluido
        contrato.Avanca();
        historico.Adiciona(contrato.SalvaEstado());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Historicos do contrato armazenados usando o padrão memento");
        Console.WriteLine();
        Console.WriteLine(historico.Pega(0).Contrato.Tipo);
        Console.WriteLine(historico.Pega(1).Contrato.Tipo);
        Console.WriteLine(historico.Pega(2).Contrato.Tipo);
        Console.WriteLine(historico.Pega(2).Contrato.Tipo);

        Console.ReadLine();

        #endregion
      }
      else if (caracterDigitado.KeyChar == 52)
      {
        #region Teste para capitulo 4 - Calculadora com DSLs e Interpreter

        IExpressao esquerda;
        IExpressao direita;

        esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
        direita = new Subtracao(new Numero(20), new Numero(10));
        IExpressao resultado1 = new Soma(esquerda, direita);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Resultado da operação (((1 + 100) + 10) + (20 + 10)) é: " + resultado1.Avalia());

        esquerda = new Multiplicacao(new Numero(14), new Numero(2));
        direita = new Divisao(new Numero(10), new Numero(2));

        IExpressao resultado2 = new Soma(esquerda, direita);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Resultado da operação (14 * 2) + (10 / 2) é: " + resultado2.Avalia());

        IExpressao resultadoRaizQuadrada = new RaizQuadrada(new Numero(9));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Resultado da raiz quadrada de 9 é: " + resultadoRaizQuadrada.Avalia());

        Console.ReadLine();

        #endregion
      }
      else if (caracterDigitado.KeyChar == 53)
      {
        #region Teste para o capitulo 5 - Calculadora usando Visitor

        IExpressao esquerda;
        IExpressao direita;

        esquerda = new Soma(new Numero(1), new Numero(10));
        direita = new Subtracao(new Numero(20), new Numero(10));
        IExpressao soma = new Soma(esquerda, direita);

        Console.WriteLine();
        Impressora impressora = new Impressora();
        Console.WriteLine("O resultado da expressão {0} é : " + soma.Avalia());
        soma.Aceita(impressora);

        Console.WriteLine();

        ImpressoraPreFixa impressoraPreFixa = new ImpressoraPreFixa();
        Console.WriteLine("Imprimindo de maneira pré-fixa, com sinal da expressão a esquerda da expressão.");
        soma.Aceita(impressoraPreFixa);

        Console.ReadLine();

        #endregion
      }
      else if (caracterDigitado.KeyChar == 54)
      {
        #region Teste para o capitulo 6 - Envio de e-mail e SMS usando Bridges

        Console.WriteLine();

        IMensagem mensagem = new MensagemCliente("Nome do Cliente");
        IEnviador enviadorSMS = new EnviaPorSMS();
        mensagem.Enviador = enviadorSMS;
        mensagem.Envia();

        Console.WriteLine();
        IMensagem mensagemParaAdministrador = new MensagemAdministrativa("Nome do Adm");
        IEnviador enviadorEmail = new EnviaPorEmail();
        mensagemParaAdministrador.Enviador = enviadorEmail;
        mensagemParaAdministrador.Envia();

        Console.ReadLine();

        //Caso eu precise de outra maneira de envio basta cliar outra classe que implemente IEnviador
        //Caso eu precise de outra mensagem, para um fornecedor por exemplo, basta implementar a IMensagem

        #endregion
      }
      else if (caracterDigitado.KeyChar == 55)
      {
        #region Teste para o capitulo 7 - Execução de uma fila de comandos usando o Command

        Console.WriteLine();

        FilaDeTrabalho filaDeTrabalho = new FilaDeTrabalho();
        Pedido pedido1 = new Pedido("Leo", 100.00);
        Pedido pedido2 = new Pedido("Marcelo", 230.00);
        filaDeTrabalho.Adiciona(new PagaPedido(pedido1));
        filaDeTrabalho.Adiciona(new PagaPedido(pedido2));
        filaDeTrabalho.Adiciona(new FinalizaPedido(pedido1));
        filaDeTrabalho.Processa();

        Console.ReadKey();
        #endregion
      }
      else if(caracterDigitado.KeyChar == 56)
      {
        #region Teste para o Capitulo 8 - Simula integração com um sistema legado ou biblioteca usando Adapter

        Cliente cliente = new Cliente();

        cliente.Nome = "Leo";
        cliente.Endereco = "Tibiriça 763";
        cliente.DataNascimento = new DateTime(1987, 05, 01);

        string xml = new GeradorDeXML().GerarXML(cliente);
 
        Console.WriteLine(xml);

        Console.ReadKey();

        #endregion
      }
      else if(caracterDigitado.KeyChar == 57)
      {
        #region Teste para o capítulo 9 - Façades e Singleton

        string cpf = "07470906614";

        EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
        Cliente cliente = facade.BuscaCliente(cpf);

        Fatura fatura = facade.CriarFatura(cliente, 5000);

        facade.GeraCobranca(Tipo.Boleto, fatura);

        Console.ReadKey();

        #endregion
      }
    }
  }
}
