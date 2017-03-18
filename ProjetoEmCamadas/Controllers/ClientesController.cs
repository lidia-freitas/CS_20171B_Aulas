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
            cli.ClienteID = listaClientes.Count + 1;
            cli.Nome = nome;
            cli.Cpf = cpf;

            listaClientes.Add(cli);
        }

        public Cliente Detalhes(int id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if(cli.ClienteID == id)
                {
                    return cli;
                }
            }
            return null;
        }

        public Cliente Editar(int id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ClienteID == id)
                {
                    return cli;
                }
            }
            return null;
        }

        public void Excluir(int id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ClienteID == id)
                {
                    listaClientes.Remove(cli);
                }
            }
        }

        public List<Cliente> Listar()
        {
            return listaClientes;
        }
    }
}
