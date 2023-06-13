using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;
using FestaInfantil.InfraDados.Arquivo.Compartilhado;
using FestaInfantil.InfraDados.Arquivo.ModuloCliente;
using FestaInfantil.InfraDados.Arquivo.ModuloTema;
using System.Windows.Forms;

namespace FestaInfantil
{
    public partial class TelaPrincipal : Form
    {

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private IRepositorioTema repositorioTema = new RepositorioArquivoTema(contextoDados);
        private IRepositorioCliente repositorioCliente = new RepositorioClienteEmArquivo(contextoDados);
        private static TelaPrincipal telaPrincipal;
        public TelaPrincipal()
        {
            InitializeComponent();
            telaPrincipal = this;
        }
        public static TelaPrincipal Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipal();

                return telaPrincipal;
            }
        }

        internal void AtualizarRodape(string mensagem)
        {
            lbRodape.Text = mensagem;
        }

        private void tpClientes_Click(object sender, EventArgs e)
        {

        }
    }
}