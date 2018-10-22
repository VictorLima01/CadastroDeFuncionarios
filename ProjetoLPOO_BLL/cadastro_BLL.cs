using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLPOO_BLL
{
    public class cadastro_BLL
    {
       public static string ValidarCadastro(Cadastro_DTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nome))
            {
                return "Campo nome vazio!";
            }
            try
            {
                int.Parse(obj.Numero);
            }
            catch
            {
                return "Campo numero deve ser um numero inteiro! ";
            }
            return Cadastro_DAL.Cadastrar(obj); 
        }


    }
}
