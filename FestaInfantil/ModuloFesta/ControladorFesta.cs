using FestaInfantil.Dominio.ModuloFesta;

namespace FestaInfantil.ModuloFesta
{
    public class ControladorFesta : ControladorBase
    {
        private IRepositorioFesta repositorioFesta;
        private TabelaFestaControl tabelaFestas;

        public ControladorFesta(IRepositorioFesta repositorioFesta)
        {
            this.repositorioFesta = repositorioFesta;
        }

        public override string ToolTipInserir => "Inserir Nova Festa";

        public override string ToolTipEditar => "Editar Festa Existente";

        public override string ToolTipExcluir => "Excluir Festa Existente";

        public override string LabelTipoCadastro => "Cadastro de Festas";

        public override void Inserir()
        {
            TelaFestaForm telaFesta = new TelaFestaForm();
            DialogResult opcaoEscolhida = telaFesta.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Festa novaFesta = telaFesta.ObterFesta();
                repositorioFesta.Inserir(novaFesta);
                CarregarFestas();
            }
        }

        public override void Editar()
        {
            TelaFestaForm telaFesta = new TelaFestaForm();
            DialogResult opcaoEscolhida = telaFesta.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Festa festa = telaFesta.ObterFesta();
                repositorioFesta.Editar(festa.id, festa);
                CarregarFestas();
            }
        }

        public override void Excluir()
        {
            Festa festa = ObterFestaSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o festa {festa.tema} ?", "Exclusão de Festas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioFesta.Excluir(festa);
                CarregarFestas();
            }
        }

        private Festa ObterFestaSelecionado()
        {
            int id = tabelaFestas.ObterIdSelecionado();
            return repositorioFesta.SelecionarPorId(id);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaFestas == null)
            {
                tabelaFestas = new TabelaFestaControl();
            }

            CarregarFestas();

            return tabelaFestas;
        }

        private void CarregarFestas()
        {
            List<Festa> festas = repositorioFesta.SelecionarTodos();
            tabelaFestas.AtualizarRegistros(festas);
        }
    }
}
