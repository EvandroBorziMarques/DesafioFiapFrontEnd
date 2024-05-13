using Interface.Models;

namespace Interface.Services
{
    public interface IAlunoService
    {
        Task Add(Aluno aluno);

        Task Update(Aluno aluno);

        Task Delete(Aluno aluno);

        Task<Aluno> GetBy(int id);

        Task<List<Aluno>> FindAll();
    }
}
