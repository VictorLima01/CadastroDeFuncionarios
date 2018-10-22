using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace ProjetoLPOO_DAL
{
    class conexao
    {
        public static MySqlConnection Conectar ()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection
                    ("server='localhost';user='root';password='@etec123';database'bd2b'");
                conn.Open();
                return conn;
            } 
            catch (Exception ex)
            {
                throw new Exception("problemas na conexão!\n" + ex.Message);

            }
            }
            

        }



    }
}
