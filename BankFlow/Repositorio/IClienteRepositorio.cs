using BankFlow.Models;

namespace BankFlow.Repositorio
{
    public interface IClienteRepositorio
    {
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);
        decimal BuscarSaldoPorClienteId(int clienteId);
    }
}
