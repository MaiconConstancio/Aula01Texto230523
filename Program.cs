using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            // O comando \n serve para pular linha
            // O Console.Write serve para escrever (Mas fica na mesma linha = string)
            // Encoder o Console.WriteLine também escreve, mas pula linha
            Console.WriteLine("Bem-vindo a Cafeteria do Conradito");
            Console.WriteLine("\n\n");
            Console.WriteLine("Essas são nossas opções");
            // ------- ATENÇÃO USAR O ; NO FINAL >SEMPRE<
            Console.WriteLine("- Café expresso R$ 2,50");
            Console.WriteLine("- Capuccino R$ 3,00");
            Console.WriteLine("- Mocca R$ 4,000");
            Console.WriteLine("\n\n");
            Console.WriteLine("Volte sempre!");


            
            Console.ReadKey(true); // Trava a tela


        }
    }
}
