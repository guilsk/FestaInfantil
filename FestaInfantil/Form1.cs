using FestaInfantil.Compartilhado;
using FestaInfantil.ModuloTema;

namespace FestaInfantil
{
    public partial class Form1 : Form
    {

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private IRepositorioTema repositorioTema = new RepositorioArquivoTema(contextoDados);
        public Form1()
        {
            InitializeComponent();
        }
    }
}