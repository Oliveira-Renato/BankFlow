using BankFlow.Data;
using BankFlow.Models;

namespace BankFlow.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public List<ClienteModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }
        public ClienteModel Adicionar(ClienteModel cliente)
        {
            // Gravar no banco de dados
            _bancoContext.Clientes.Add(cliente);
            _bancoContext.SaveChanges();

            return cliente;
        }

    }
}
