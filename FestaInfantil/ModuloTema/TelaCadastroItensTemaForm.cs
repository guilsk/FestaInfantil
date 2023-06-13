

using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloTema {
    public partial class TelaCadastroItensTemaForm : Form {
        public TelaCadastroItensTemaForm(Tema tema) {
            InitializeComponent();

            this.ConfigurarDialog();


            ConfigurarTela(tema);
        }

        private void ConfigurarTela(Tema tema) {
            txtId.Text = tema.id.ToString();
            txtTitulo.Text = tema.nome;

            listItens.Items.Clear();

            foreach (ItemTema item in tema.itens) {
                listItens.Items.Add(item);
            }
        }

        public List<ItemTema> ObterItensCadastrados() {
            return listItens.Items.Cast<ItemTema>().ToList();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e) {
            if (txtDescricao.Text != "" && txtValor.Text != "") {

                string nome = txtDescricao.Text;
                decimal valor = Convert.ToDecimal(txtValor.Text);

                ItemTema itemTema = new ItemTema(nome, valor);

                listItens.Items.Add(itemTema);

                txtDescricao.Text = "";
                txtValor.Text = "";

            } else {
                MessageBox.Show("A descrição do item não pode ficar vazia.", "Inclusão de itens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
