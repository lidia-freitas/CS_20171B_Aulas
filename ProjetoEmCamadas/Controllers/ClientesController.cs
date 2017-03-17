using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class ClientesController
    {
        private static List<Cliente> listaClientes = new List<Cliente>();

        public void Adicionar(string nome, string cpf)
        {
            Cliente cli = new Cliente();
            cli.Nome = nome;
            cli.Cpf = cpf;

            listaClientes.Add(cli);
        }


    }
}
