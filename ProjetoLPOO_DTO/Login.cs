using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLPOO_DTO
{
    class Login
    {
        try
        { Login_DTO obj = new Login_DTO();
        object.Usuario= txtUsuario.text;
        object.Senha= txtSenha.text;
            string retorno;
        retorno= Login_BLL.ValidarLogin(obj);
            if(retorno == "sucesso")
            {
            this.hide();
        Principal tela = new Principal();
        Tela.ShowDiaLog();
        this. Close();

    }
    else
    {
    MessageBox.Show(retorno,"erro",MessageBoxButtons.ok,MessageBoxIcon.error)
    }

        }
catch (Exception ex)
    {
    MessageBox.Show(retorno,"erro",MessageBoxButtons.ok,MessageBoxIcon.error)
    }

    }
}
