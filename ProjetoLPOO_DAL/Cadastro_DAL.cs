using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
namespace ProjetoLPOO_DAL
{
    public class Cadastro_DAL
    {
        public static string Cadastrar (Cadastro_DTO obj)
        {
            try
            {
                string sql = "INSERT INTO funcionario (nome,sobrenome,cep,telefone,email) VALUES" +
                    "(@nome,@sobrenome,@cep,@telefone,@email)";
                MySqlComand cm = new(MySqlComand(sql, conexao.Conectar());

                cm.Parameters.addWhithValue("@nome", obj.nome);
                cm.Parameters.addWhithValue("@sobrenome", obj.sobrenome);
                cm.Parameters.addWhithValue("@cep", obj.cep);
                cm.Parameters.addWhithValue("@telefone", obj.telefone);
                cm.Parameters.addWhithValue("@email", obj.email);
                cm.ExecuteNonQuery();
                return "cadastro com sucesso";
            }
            catch (Exception xota_suja)
            {
                throw new Exception("problemas na conexão" + xota_suja.Message);
            }
            finally
            {
                if (conexao.Conectar ().State !=ConnectionState.closed)
                {
                    conexao.Conectar().Close();
                }
            }
            

        }


    }
}
