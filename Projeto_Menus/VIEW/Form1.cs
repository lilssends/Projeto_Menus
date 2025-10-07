using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Menus
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal() // Construtor (É o primeiro método a ser executado quando o formulário é chamado)
        {//Inicio do Método
            InitializeComponent();
            lblUsuario.Text = "Usuário - Lilssen Kleber ";
            lblData.Text = "Data Atual - " + DateTime.Now.ToShortDateString();
            lblHora.Text = "Hora Atual - " + DateTime.Now.ToLongTimeString();
            lblVersao.Text = "Versão do Sistema - " + Application.ProductVersion;
        }//Fim do Método

        public frmPrincipal(string usu) // Sobrecarga do Construtor (É o primeiro método a ser executado quando o formulário é chamado)
        {//Inicio do Método
            InitializeComponent();
            lblUsuario.Text = "Usuário - " + usu;
            lblData.Text = "Data Atual - " + DateTime.Now.ToShortDateString();
            lblHora.Text = "Hora Atual - " + DateTime.Now.ToLongTimeString();
            lblVersao.Text = "Versão do Sistema - " + Application.ProductVersion;
        }//Fim do Método

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e) //Evento de clique do menu Salvar Como
        {//Inicio do Método
            frmSalvarComo salvarComo = new frmSalvarComo(); //Instanciando o formulário Salvar Como
            salvarComo.Show(); //Não Modal

        }//Fim do Método

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) //Evento de clique do menu Sobre
        {
            frmSobre sobre = new frmSobre(); //Instanciando o formulário Sobre
            sobre.ShowDialog(); //Modal
        }

        private void tmrHora_Tick(object sender, EventArgs e) //Evento de Tick do Timer
        {
            lblHora.Text = "Hora Atual - " + DateTime.Now.ToLongTimeString(); //Atualizando a hora
        }

        private void calculadoraWindowsToolStripMenuItem_Click(object sender, EventArgs e) //Evento de clique do menu Calculadora Windows
        {
            process1.StartInfo.FileName = "calc.exe"; //Abrindo a calculadora do Windows
            process1.Start(); //Iniciando o processo
        }

        private void manualSistemaToolStripMenuItem_Click(object sender, EventArgs e) //Evento de clique do menu Manual do Sistema
        {
            process1.StartInfo.FileName = @"G:\PROJETOS\DS\Projeto_Menus\ManualSistema.pdf";
            process1.Start();
        }

        private void mostrarBarraDeStatusToolStripMenuItem_Click(object sender, EventArgs e) //Evento de clique do menu Mostrar Barra de Status
        {
            if (mostrarBarraDeStatusToolStripMenuItem.Checked) //Verificando se o menu está checado
            {
                statusStrip1.Visible = true; //Mostrando a barra de status
            }
            else //Se o menu não estiver checado
            {
                statusStrip1.Visible = false; //Escondendo a barra de status
            }
        }

        private void btnSair_Click(object sender, EventArgs e) //Evento de clique do botão Sair
        {
            if (MessageBox.Show("Finalizar?", 
                "Saída do Sistema", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == 
                DialogResult.Yes) //Perguntando se o usuário deseja realmente sair
            {
                this.Close(); //Fechando o formulário
            }
        }

        
    }
}
