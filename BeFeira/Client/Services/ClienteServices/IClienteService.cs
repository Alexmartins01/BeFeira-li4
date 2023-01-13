﻿namespace BeFeira.Client.Services.ClienteServices
{
    public interface IClienteService
    {
        List<Cliente> clientes { get; set; }
        Task GetClientes();

        Task<Cliente> GetSingleCliente(int id);
    }
}
