using Interface.Models;
using NuGet.Protocol;

namespace Interface.Services
{
    public class TurmaService : ITurmaService
    {
        public async Task Add(Turma turma)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"https://localhost:7042/api/turma/create");
            var teste = turma.ToJson();
        }

        public async Task Update(Turma turma)
        {
            
        }

        public async Task Delete(Turma turma)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"https://localhost:7042/api/turma/delete/{turma.Id}");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
        }

        public async Task<Turma> GetBy(int id)
        {
            HttpClient client = new HttpClient();
            Turma turma = new Turma();
            client.BaseAddress = new Uri($"https://localhost:7042/api/turma/{id}");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                turma = Newtonsoft.Json.JsonConvert.DeserializeObject<Turma>(json);
            }

            return turma;
        }

        public async Task<List<Turma>> FindAll()
        {
            List<Turma> turmas = new();
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://localhost:7042/api/turma/list");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                turmas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Turma>>(json);
            }

            return turmas;
        }
    }
}
