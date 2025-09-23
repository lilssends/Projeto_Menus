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
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {//Inicio do Método
            frmSalvarComo salvarComo = new frmSalvarComo();
            salvarComo.Show(); //Não Modal

        }//Fim do Método

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog(); //Modal
        }
    }
}
