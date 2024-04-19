using BankFlow.Models;

namespace BankFlow.Repositorio
{
    public interface IClienteRepositorio
    {
        ClienteModel Adicionar(ClienteModel cliente);
    }
}
