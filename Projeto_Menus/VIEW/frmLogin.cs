using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Menus
{
    public partial class frmLogin : Form // Herdando o frmSalvarComo para reaproveitar o código do InitializeComponent
    {

        public Boolean Acesso = false; // Variável para verificar se o acesso foi concedido para acessar o formulário da aplicação, serve para podemros acessar depois do Program.cs
        public string Usuario = string.Empty; // Variável para armazenar o nome do usuário que fez o login

        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e) // Evento de mudança do CheckBox
        {
            if (chkMostrar.Checked) // Se o CheckBox estiver marcado
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else // Se o CheckBox não estiver marcado
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e) // Evento de clique do botão Finalizar
        {
            this.Close();
        }

        private void btnAcessar_Click(object sender, EventArgs e) // Evento de clique do botão Acessar
        {
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "1234") // Verificando se o usuário e senha estão corretos
            {
                MessageBox.Show("Acesso Concedido! Seja Bem-vindo - " + txtUsuario.Text, "Login", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information); // Mensagem de boas vindas
                Acesso = true; // Concedendo o acesso
                Usuario = txtUsuario.Text; // Armazenando o nome do usuário
                this.Close();

            }
            else // Se o usuário ou senha estiverem incorretos
            {
                MessageBox.Show("Acesso Negado! Usuário ou Senha Inválidos", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensagem de erro
                Acesso = false; // Negando o acesso
            }
        }
    }
}
