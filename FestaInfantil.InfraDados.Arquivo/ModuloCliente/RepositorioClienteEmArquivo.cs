using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;
using FestaInfantil.InfraDados.Arquivo.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestaInfantil.InfraDados.Arquivo.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioEmArquivoBase<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto) { }

        protected override List<Cliente> ObterRegistros()
        {
            return contextoDados.clientes;
        }
    }
}