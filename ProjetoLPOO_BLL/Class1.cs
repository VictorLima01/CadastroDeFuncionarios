using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLPOO_DTO;
using ProjetoLPOO_DAL;

namespace ProjetoLPOO_BLL
{
    public class Login_BLL
    {
        public static string ValidarLogin (Login_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Usuario))
                {
                return "Campo usuário vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.Senha))
            {
                return "Campo senha vazio";
            }
            if (string.IsNullOrWhiteSpace(obj.ConfSenha))
            {
                return "Campo confirmar senha vazio";
            }
            if (obj.Senha != obj.ConfSenha)
            {
                return "As senhas não conferem";
            }
            return "Sucesso";
        }
    }
}
