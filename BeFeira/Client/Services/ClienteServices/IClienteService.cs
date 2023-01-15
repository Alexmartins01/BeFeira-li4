namespace BeFeira.Client.Services.ClienteServices
{
    public interface IClienteService
    {
        List<Cliente> clientes { get; set; }
        Task GetClientes();

        Task<int> getmyid();

        Task<Cliente> GetSingleCliente(int id);

         Task<int> ValidClient(String username,String pass);

        Task AddCliente(Cliente client);

        Task UpdateCliente(Cliente cli);
    }
}
