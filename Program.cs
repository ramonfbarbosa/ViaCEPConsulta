using System;
using System.Threading;
using ViaCEPConsulta.Controller;

namespace ViaCEPConsulta
{
    class Program
    {
        static void Main(string[] args)
        {
            ViaCEPController controller = new ViaCEPController();

            Console.WriteLine("***INFORME O CEP***");
            string cep = Console.ReadLine();
            while (cep.Length > 8 || cep.Length < 8)
            {
                Console.WriteLine("\n***Digite um CEP nativo***");
                cep = Console.ReadLine();
            }

            controller.GetCEP(cep);

            Thread.Sleep(10000);
        }
    }
}
