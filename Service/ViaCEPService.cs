using RestSharp;

namespace ViaCEPConsulta.Service
{
    class ViaCEPService
    {
        public string AutorizaCEP(string cep)
        {
            var site = new RestClient($"https://apps.widenet.com.br/busca-cep/api/cep.json?code={cep}");
            RestRequest req = new RestRequest(Method.GET);

            IRestResponse response = site.Execute(req);
            if (response.IsSuccessful)
            {
                return response.Content;
            }
            else
            {
                return response.ErrorMessage;
            }
        }
    }
}
