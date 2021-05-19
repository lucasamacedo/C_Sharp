using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto += 3;

            dynamic dinamico = 1;
            dinamico += 3;
            Console.WriteLine(dinamico);

            //dinamico.teste(); // da erro, pois em tempo de compilação ele não sabe que tipo é,
            //então não sabe se tem um método teste();
        }
    }
}
