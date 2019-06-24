using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto3Camadas.Code.DAL
{
    class AcessoBancoDados
    {
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;

        private string server = "localhost";
        private string user = "root";
        private string password = "";
        private string database = "bdcliente";

        public void Conectar()
        {
            if (conn != null)
                conn.Close();

            string connStr = String.Format("server={0};uid={1};pwd={2};database={3}", server, user, password, database);

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch(MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExecutarComandoSQL(string comandoSQL)
        {
            MySqlCommand comando = new MySqlCommand(comandoSQL, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conn);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        public MySqlDataReader RetDataReader(string sql)
        {
            MySqlCommand comando = new MySqlCommand(sql, conn);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();

            return dr;
        }
    }
}
