using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_segunda
{
    class Program
    {
        static void Main(string[] args)
        {
            double imp;
            Console.Write("imforme o valor total da venda: ");
            double total_venda = double.Parse(Console.ReadLine());

            Console.WriteLine("imforme o seu estado" +
                "\n1:SP  " +
                "\n2:RJ  " +
                "\n3:DF  " +
                "\n4:RS  " +
                "\n5:PR");
            double estado = double.Parse(Console.ReadLine());

            switch(estado)

            {
                case  1:
                   imp = total_venda*(0.18);

                    Console.Write("O VALOR DO SEU IMPOSTO SERA DE: " + imp);
                    
                    break;

                case 2:
                    imp = total_venda * (0.16);
                    Console.Write("O VALOR DO SEU IMPOSTO SERA DE: " + imp);
                    
                    break;
                case 3:

                    imp = total_venda * (0.15);
                    Console.Write("O VALOR DO SEU IMPOSTO SERA DE: " + imp);
                   
                    break;

                case 4:
                    imp = total_venda * (0.12);
                    Console.Write("O VALOR DO SEU IMPOSTO SERA DE: " + imp);
                    
                    break;
                case 5:
                    imp = total_venda *(0.10);
                    Console.Write("O VALOR DO SEU IMPOSTO SERA DE: " + imp);
                    
                    break;

                default :
                    Console.Write("valor invalido");
                   
                    break;
                  
                    

            }
            Console.ReadKey();
        }
    }
}
