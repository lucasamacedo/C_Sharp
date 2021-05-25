using System;
using System.IO;

namespace _01._4.IDisposable_Finalizador
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");

            //throw new IOException();
            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
        //private static void CarregarContas()
        //{
        //    LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

        //    leitor.LerProximaLinha();
        //    leitor.LerProximaLinha();
        //    leitor.LerProximaLinha();

        //    leitor.Fechar();
        //}
    }
}