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
            var clientes = _bancoContext.Clientes.ToList();

            // Atualize o valor do saldo para cada cliente
            foreach (var cliente in clientes)
            {
                cliente.Saldos = new SaldoModel
                {
                    Saldo = BuscarSaldoPorClienteId(cliente.Id)
                };
            }

            return clientes;
        }
        public ClienteModel Adicionar(ClienteModel cliente)
        {
            // Gravar no banco de dados
            _bancoContext.Clientes.Add(cliente);
            _bancoContext.SaveChanges();

            return cliente;
        }

        public decimal BuscarSaldoPorClienteId(int clienteId)
        {
            // Consulta o banco de dados para obter o saldo do cliente com o ID correspondente
            // Implementa a lógica para recuperar o saldo (por exemplo, consultando a tabela de saldos)

            var saldo = _bancoContext.Saldos
                .Where(s => s.ClienteId == clienteId)
                .Select(s => s.Saldo)
                .FirstOrDefault();

            return saldo;
        }

    }
}
