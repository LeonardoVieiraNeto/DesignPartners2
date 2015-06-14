using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartners2.Cap1
{
  public class ConnectionFactory
  {
    public IDbConnection GetConnection()
    {
      ahhahdadhahd
      IDbConnection conexao = new SqlConnection();
      conexao.ConnectionString = "User Id =root;Password=;Server=localhost;DataBase=Meubanco";
      //conexao.Open();
      return conexao;
    }
  }
}
