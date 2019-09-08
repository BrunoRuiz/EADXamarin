using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCEP.Service
{
    public class ServiceCEP
    {
        private static string UrlBase = "https://viacep.com.br/ws/{0}/json/";

        public async static Task<string> BuscaCEP(string cep)
        {

            string Url = string.Format(UrlBase, cep);

            HttpClient http = new HttpClient();
            string json = await http.GetStringAsync(Url);

            dynamic objetoCEP = JsonConvert.DeserializeObject<dynamic>(json);

            string result = string.Format("CEP: {0} \n Endereço: {1} \n Bairro: {2} \n Cidade: {3} \n UF: {4}",
                objetoCEP.cep, objetoCEP.logradouro, objetoCEP.bairro, objetoCEP.localidade, objetoCEP.uf);

            return result;

        }
    }
}
