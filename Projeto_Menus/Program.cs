using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Menus
{
    internal static class Program // Classe estática Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread] // Atributo que indica que o modelo de threading do aplicativo é single-threaded apartment
        static void Main() // Método Main - Ponto de entrada do aplicativo
        {
            Application.EnableVisualStyles(); // Habilita os estilos visuais para o aplicativo
            Application.SetCompatibleTextRenderingDefault(false); // Define o modo de renderização de texto compatível

            frmLogin login = new frmLogin(); // Criando uma instância do formulário de login
            login.ShowDialog(); // Mostrando o formulário de login como uma caixa de diálogo modal

            if (login.Acesso == true) // Verificando se o acesso foi concedido
            {
                Application.Run(new frmPrincipal(login.Usuario)); // Se o acesso foi concedido, abrir o formulário principal
            }
            
        }
    }
}
