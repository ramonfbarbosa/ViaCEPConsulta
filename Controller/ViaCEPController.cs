using Newtonsoft.Json;
using System;
using ViaCEPConsulta.DTO;
using ViaCEPConsulta.Service;

namespace ViaCEPConsulta.Controller
{
    class ViaCEPController
    {
        public void GetCEP(string cep)
        {
            ViaCEPService service = new ViaCEPService();
            string content = service.AutorizaCEP(cep);

            while (content == null)
            {
                Console.WriteLine("\n***Digite um CEP nativo***");
                cep = Console.ReadLine();
            }

            if (content != null)
            {
                ViaCEPDTO obj = JsonConvert.DeserializeObject<ViaCEPDTO>(content);
                Console.WriteLine(obj);
            }
            
        }
    }
}
