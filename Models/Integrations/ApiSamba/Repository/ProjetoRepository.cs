using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace JemakEadPro.Models.Integrations.Samba.ApiSamba
{
    public class ProjetoRepository
    {
        HttpClient cliente = new HttpClient();
        public string token { get; set; } // = "07e6299f-973b-47a2-a51e-69d70a57c325";
        public int pid { get; set; }

        public ProjetoRepository()
        {
            cliente.BaseAddress = new Uri("http://api.sambavideos.sambatech.com/v1/");
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Projeto>> GetSambaProjetosAsync()
        {
            HttpResponseMessage res = await cliente.GetAsync($"projects?access_token={token}");
            var dados = await res.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<List<Projeto>>(dados);
        }

        public async Task<List<Media>> GetSambaMediaAsync()
        {
            HttpResponseMessage res = await cliente.GetAsync($"medias?access_token={token}&pid={pid}");
            var dados = await res.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Media>>(dados);
        }
        

    }
}