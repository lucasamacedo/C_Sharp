using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            // operador is ve se uma variavel é de determinado tipo
            // operador as faz o cast explícito com segurança

            //Animal animal = obj as Animal;

            //if (obj is IAnimal)
            //{
            //    animal = (Animal)obj;
            //}
            if (obj is Animal animal) // se der certo, declara uma variavel chamada animal e vai receber o cast caso essa conversão possa ser feita
            {
                animal.Beber();
                animal.Comer();
                return;
            }
            Console.WriteLine("obj não é um animal");
        }
    }
}
