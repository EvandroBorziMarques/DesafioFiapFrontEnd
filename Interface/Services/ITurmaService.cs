using Interface.Models;

namespace Interface.Services
{
    public interface ITurmaService
    {
        Task Add(Turma turma);

        Task Update(Turma turma);

        Task Delete(Turma turma);

        Task<Turma> GetBy(int id);

        Task<List<Turma>> FindAll();
    }
}
