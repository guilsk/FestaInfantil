using FestaInfantil.Dominio.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.Dominio.ModuloCliente
{
    public interface IRepositorioCliente
    {
        void Inserir(Cliente novoCliente);
        void Editar(int id, Cliente cliente);
        void Excluir(Cliente clienteSelecionado);
        Cliente SelecionarPorId(int id);
        List<Cliente> SelecionarTodos();

    }

}
