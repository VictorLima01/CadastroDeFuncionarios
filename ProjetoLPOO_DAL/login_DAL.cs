using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLPOO_DTO;

namespace ProjetoLPOO_DAL
{
    class login_DAL
    {
        public static string ValidarLogin(Login_DTO obj)
        
        try
        {
        string script = "SELECT * FROM usuario WHERE usuario = @usuario AND senha = @senha ";
        MySqlCommand cm = new MySqlCommand(script, conexao.Conectar());
        cm.Parameters.AddWithvalue("@usuario", obj.Usuario);
        cm.Parameters.AddWithvalue("@senha", obj.Senha);
        
            MySqlDataReader dados = cm.ExecuteReader();


        while (dados.Read()){
            
            if(dados.HasRows)
            {
            
            return "sucesso";

            }
            
              return "Usuario ou senha invalidos!";
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas na conexão!\n" + ex.Message);

        }

    }
}
