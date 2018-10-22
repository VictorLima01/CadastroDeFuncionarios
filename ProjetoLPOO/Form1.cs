using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLPOO_BLL;
using ProjetoLPOO_DTO;

namespace ProjetoLPOO_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_DTO obj = new Login_DTO();
            obj.Usuario = UsuarioOBJ.Text;
            obj.Senha = SenhaOBJ.Text;
            obj.ConfSenha = ConfSenhaOBJ.Text;
            string texto;
            texto = Login_BLL.ValidarLogin(obj);
            if (texto == "sucesso")
            {
                this.Hide();
                Pricipal tela = new Principal();
                tela.ShowDialog();
                this.Close();

            }
            else {

                MessageBox.Show(texto);
            }

        }
    }
}
