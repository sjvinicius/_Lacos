using System;

namespace _Lacos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Selecione o valor da sua tabuada: ");
            int v = int.Parse( Console.ReadLine() );

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine ($" {v} x {i} = {v * i} ");
            }
           
           
           
           
           
           
           
            // Console.WriteLine ("Deseja receber bom dia ? (s) (n)");
            //     string ans = Console.ReadLine ();
            
            // do {
            //     Console.WriteLine("BOM DIA !!!");
            //     Console.WriteLine("Continuar ? (s) (n)");
            //     ans = Console.ReadLine();

            // } while (ans == "s");



            //WHILE

            // Console.WriteLine("Deseja receber um bom dia ? (s) ou (n)");
            // string ans = Console.ReadLine();

            // while (ans == "s") {
                
            //     Console.WriteLine("bom dia !");
            //     Console.WriteLine("deseja receber outro bom dia?)");
            //     ans = Console.ReadLine();
            // }
        }
    }
}
