﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME;

            Console.Write("Escreva seu nome: ");
            NOME = Console.ReadLine();
            Console.WriteLine("Olá, " + NOME);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
