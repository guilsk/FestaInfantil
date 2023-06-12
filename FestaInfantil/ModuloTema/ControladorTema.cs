using FestaInfantil.Compartilhado;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema {
    public class ControladorTema : ControladorBase {


        private IRepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTemas;


        public ControladorTema(IRepositorioTema repositorioTema) {
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir novo Tema";

        public override string ToolTipEditar => "Editar Tema Existente";

        public override string ToolTipExcluir => "Excluir Tema Existente";

        public override string LabelTipoCadastro => "Cadastro de Temas";

        public override void Inserir() {
            TelaTemaForm telaTema = new TelaTemaForm();
            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Tema novoTema = telaTema.ObterTema();
                repositorioTema.Inserir(novoTema);
                CarregarTemas();
            }
        }

        public override void Editar() {

            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null) {
                MessageBox.Show("Nenhum Tema Selecionado!", "Editar Temas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTemaForm telaTema = new TelaTemaForm();
            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Tema tema = telaTema.ObterTema();

                repositorioTema.Editar(tema.id, tema);

                CarregarTemas();
            }
        }

        public override void Excluir() {
            Tema tema = ObterTemaSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o tema {tema.nome} ?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {

                repositorioTema.Excluir(tema);
                CarregarTemas();
            }
        }

        private Tema ObterTemaSelecionado() {
            int id = tabelaTemas.ObterIdSelecionado();
            return repositorioTema.SelecionarPorId(id);
        }


        public override UserControl ObterListagem() {
            if (tabelaTemas == null) {
                tabelaTemas = new TabelaTemaControl();
            }

            CarregarTemas();

            return tabelaTemas;
        }

       
        private void CarregarTemas() {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            tabelaTemas.AtualizarRegistros(temas);
        }
    }
}
