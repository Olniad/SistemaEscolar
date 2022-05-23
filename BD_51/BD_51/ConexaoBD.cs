using MySql.Data.MySqlClient;
using System.Data;
namespace BD_51{
    class ConexaoBD{
        private MySqlConnection conexao;
        public void ConectarBD(){
            
                conexao = new MySqlConnection("persist security info = false;" +
                                              "server=localhost;" +
                                              "database=alunos_2A1_51;" +
                                              "uid=root;pwd=;SslMode=none");
                conexao.Open();
        }
        public void AlterarTabelas(string sql){
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql,conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }
        public DataTable ConsultarTabelas(string sql){        
            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }

    }
}
