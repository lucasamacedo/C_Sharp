using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._4.IDisposable_Finalizador
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMensagem());
            CarregarContas();
        }
        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }
    }
    
}
