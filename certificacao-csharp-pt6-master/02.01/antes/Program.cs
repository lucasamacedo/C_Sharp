using System;

namespace _02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Código";

            //Console.WriteLine(alura);
            //Console.WriteLine(caelum);
            //Console.WriteLine(casaDoCodigo);

            // MATRIZ = ARRAY

            //string[] empresas = new string[3];
            //empresas[0] = alura;
            //empresas[1] = caelum;
            //empresas[2] = casaDoCodigo;

            //string[] empresas = new string[]
            //{
            //    alura, caelum, casaDoCodigo
            //};
            string[] empresas = { alura, caelum, casaDoCodigo };

            Imprimir(empresas);

            caelum = "Caelum Ensino e Inovação";

            Imprimir(empresas);

            empresas[1] = "Caelum Ensino e Inovação";

            Imprimir(empresas);

            Console.WriteLine("Primeiro elemento: " + empresas[0]);
            Console.WriteLine("Último elemento: " + empresas[empresas.Length - 1]);

            Console.WriteLine("O índice de 'Casa do Código' é: " + Array.IndexOf(empresas, "Casa do Código"));
            Console.WriteLine("O último índice de 'Casa do Código' é: " + Array.LastIndexOf(empresas, "Casa do Código"));

            // Revertendo a sequência do array

            Array.Reverse(empresas);
            Imprimir(empresas);

            // Revertendo NOVAMENTE a sequência do array

            Array.Reverse(empresas);
            Imprimir(empresas);

            // Redimensionando um array (Truncando a última posição)
            Array.Resize(ref empresas, 2);
            Imprimir(empresas);

            // Redimensionando um array (deixando a última posição vazia)
            Array.Resize(ref empresas, 3);
            Imprimir(empresas);

            empresas[empresas.Length - 1] = "Casa do Código";

            Array.Sort(empresas);
            Imprimir(empresas);

            string[] copia = new string[2];
            Array.Copy(empresas, 1, copia, 0, 2);

            Imprimir(copia);

            string[] clone = empresas.Clone() as string[];
            Imprimir(clone);

            Array.Clear(clone, 1, clone.Length - 1);
            Imprimir(clone);
        }

        private static void Imprimir(string[] empresas)
        {
            //for (int i = 0; i < empresas.Length; i++)
            //{
            //    string empresa = empresas[i];
            //    Console.WriteLine(empresa);
            //}
            // Como a classe Array implementa a interface ICollection que implementa a interface IEnumerable, podemos fazer:
            foreach (var empresa in empresas)
            {
                Console.WriteLine(empresa);
            }
        }
    }
}
