using FestaInfantil.Compartilhado;
using FestaInfantil.Dominio.ModuloTema;
using FestaInfantil.InfraDados.Arquivo.Compartilhado;
using FestaInfantil.InfraDados.Arquivo.ModuloTema;
using FestaInfantil.ModuloTema;

namespace FestaInfantil
{
    public partial class TelaPrincipal : Form
    {

        private ControladorBase controlador;

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);

        private IRepositorioTema repositorioTema = new RepositorioArquivoTema(contextoDados);
        
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        private void btnInserir_Click(object sender, EventArgs e) {
            controlador.Inserir();
        }
        private void btnEditar_Click(object sender, EventArgs e) {
            controlador.Editar();
        }
        private void btnExcluir_Click(object sender, EventArgs e) {
            controlador.Excluir();
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e) {

            controlador = new ControladorTema(repositorioTema);
            ConfigurarTelaPrincipal(controlador);


        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador) {
            labelTipoCadastro.Text = controlador.LabelTipoCadastro;
            toolStrip1.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controlador) {
            UserControl listagem = controlador.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador) {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

    }
}