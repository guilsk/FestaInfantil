using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.InfraDados.Arquivo.ModuloTema
{
    public class RepositorioArquivoTema : RepositorioEmArquivoBase<Tema>, IRepositorioTema
    {
        public RepositorioArquivoTema(ContextoDados contexto) : base(contexto){}

        protected override List<Tema> ObterRegistros()
        {
            return contextoDados.temas;
        }
    }
}
