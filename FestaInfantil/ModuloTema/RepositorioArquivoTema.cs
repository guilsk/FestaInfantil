
using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloTema {
    internal class RepositorioArquivoTema : RepositorioEmArquivoBase<Tema>, IRepositorioTema {

        public RepositorioArquivoTema(ContextoDados contexto) : base(contexto) {
        }


        protected override List<Tema> ObterRegistros() {
            return contextoDados.temas;
        }
    }
}
