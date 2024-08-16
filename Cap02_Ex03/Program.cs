using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL; //Criando variáveis do tipo float

            Console.Write("Horas trabalhadas ...............: "); //Escreva as horas trabalhadas
            HT = float.Parse(Console.ReadLine()); //HT recebe um número com um ponto flutuante e leia
            Console.Write("Valor da hora ...............: "); //Escreva o valor da hora
            VH = float.Parse(Console.ReadLine()); //VH recebe um número com um ponto flutuante e leia
            Console.Write("Valor do percentual de desconto .: "); //Escreva o valor do percentual de desconto
            PD = float.Parse(Console.ReadLine()); //PD recebe um número com um ponto flutuante e leia

            SB = HT * VH; //SB recebe os valores de HT vezes VH
            TD = (PD / 100) * SB; //TD recebe o valor de PD, divide por 100 e depois multiplica por SB
            SL = SB - TD; //SL recebe o valor de SB e subtrai por TD

            Console.WriteLine(); //Pula uma linha
            Console.Write("Salario liquido ...............: "); //Escreva o salário líquido
            Console.WriteLine(SL.ToString("##,##0.00")); //Pula uma linha e escreve o valor do salário líquido

            Console.WriteLine(); //Pula uma linha
            Console.Write("Tecla <Enter> para encerrar... "); //Escreva, tecla enter para encerrar
            Console.ReadLine(); //Leia, caso for clicado o enter
        }
    }
}
