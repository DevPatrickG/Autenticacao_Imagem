using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAutenticidade
{
    class clsConexao
    {
        public SqlConnection Conectar()
        {
            String strConexao = @"Data Source=DESKTOP-JB5CLQ3\SQLEXPRESS;Initial Catalog=Autenticidade;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strConexao);
            if (sqlCon.State.ToString() == "Closed")
            {
                sqlCon.Open();
            }

            return sqlCon;

        }

        public SqlDataReader Consulta (String cons)
        {
            SqlDataReader dtDados;
            SqlConnection cons1 = Conectar();
            SqlCommand comando = new SqlCommand(cons, cons1);
            dtDados = comando.ExecuteReader();

            return dtDados;
        }
        public String InserirDados(String comandoInsercao)
        {
            SqlConnection con1 = Conectar();
            SqlCommand insere = new SqlCommand(comandoInsercao, con1);
            insere.ExecuteNonQuery();

            return "inserido com sucesso";
        }
    }
}
