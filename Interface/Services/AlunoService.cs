using Interface.Models;
using NuGet.Protocol;
using System.Text;

namespace Interface.Services
{
    public class AlunoService : IAlunoService
    {
        public async Task Add(Aluno aluno)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"https://localhost:7042/api/aluno/create");
            var teste = aluno.ToJson();
            //await client.PostAsync(client.BaseAddress, )

            //HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
        }

        public async Task Update(Aluno aluno)
        {
            //dbContext.Update(company);
            //await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Aluno aluno)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"https://localhost:7042/api/aluno/delete/{aluno.Id}");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
        }

        public async Task<Aluno> GetBy(int id)
        {
            HttpClient client = new HttpClient();
            Aluno aluno = new Aluno();
            client.BaseAddress = new Uri($"https://localhost:7042/api/aluno/{id}");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                aluno = Newtonsoft.Json.JsonConvert.DeserializeObject<Aluno>(json);
            }

            return aluno;
        }

        public async Task<List<Aluno>> FindAll()
        {
            List<Aluno> alunos = new();
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://localhost:7042/api/aluno/list");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                alunos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Aluno>>(json);
            }

            return alunos;
        }
    }
}
