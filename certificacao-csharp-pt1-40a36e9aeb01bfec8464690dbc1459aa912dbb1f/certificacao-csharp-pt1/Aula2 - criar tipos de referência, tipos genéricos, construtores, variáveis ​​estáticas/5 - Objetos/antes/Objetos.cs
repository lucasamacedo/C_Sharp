﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
           int pontuacao = 10;
           Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuObjeto: {meuObjeto}");
            Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");


            Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador) meuObjeto; // conversão explícita, ou "cast"

            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");

        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
