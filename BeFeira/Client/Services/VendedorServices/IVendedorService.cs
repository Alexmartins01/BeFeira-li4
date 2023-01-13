﻿namespace BeFeira.Client.Services.VendedorServices
{
    public interface IVendedorService
    {
        List<Vendedor> vendedores { get; set; }
        Task GetVendedores();

        Task<Vendedor> GetSingleVendedor(int id);
        Task<bool> ValidVendedor(string username,string pass);
    }
}
