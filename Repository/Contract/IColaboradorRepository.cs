using LojaGame_AspCore.Models;

namespace LojaGame_AspCore.Repository.Contract
{
    public interface IColaboradorRepository
    {
        //CRUD
        IEnumerable<Colaborador> ObterTodosColaboradores();
        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        Colaborador ObterColaboradores(int Id);
        void Excluir(int Id);
    }
}
