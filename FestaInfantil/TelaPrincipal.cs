namespace FestaInfantil
{
    public partial class TelaPrincipal : Form
    {

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private IRepositorioTema repositorioTema = new RepositorioArquivoTema(contextoDados);
        
        public TelaPrincipal()
        {
            InitializeComponent();
        }


    }
}