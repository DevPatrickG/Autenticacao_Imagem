using System;
using System.Data.SqlClient;


namespace ProjetoAutenticidade
{
    class ClsConection
    {
        public SqlConnection Connect()
        {
            String strConexao = @"Data Source=DESKTOP-JB5CLQ3\SQLEXPRESS;Initial Catalog=Autenticidade;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(strConexao);
            if (sqlCon.State.ToString() == "Closed")
            {
                sqlCon.Open();
            }

            return sqlCon;

        }

        public SqlDataReader Query (String cons)
        {
            SqlDataReader dtDados;
            SqlConnection cons1 = Connect();
            SqlCommand comando = new SqlCommand(cons, cons1);
            dtDados = comando.ExecuteReader();

            return dtDados;
        }
        public String Insert(String comandoInsercao)
        {
            SqlConnection con1 = Connect();
            SqlCommand insert = new SqlCommand(comandoInsercao, con1);
            insert.ExecuteNonQuery();

            return "inserido com sucesso";
        }
    }
}
