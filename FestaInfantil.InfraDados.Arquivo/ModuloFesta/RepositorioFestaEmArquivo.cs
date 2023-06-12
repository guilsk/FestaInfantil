using FestaInfantil.Dominio.ModuloFesta;

namespace FestaInfantil.InfraDados.Arquivo.ModuloFesta
{
    public class RepositorioFestaEmArquivo : RepositorioEmArquivoBase<Festa>, IRepositorioFesta
    {
        public RepositorioFestaEmArquivo(ContextoDados contexto) : base(contexto) { }

        protected override List<Festa> ObterRegistros()
        {
            return contextoDados.festas;
        }
    }
}
