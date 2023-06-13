using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloFesta;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.ModuloFesta
{
    public partial class TelaFestaForm : Form
    {
        public TelaFestaForm(IRepositorioTema temas, IRepositorioCliente clientes)
        {
            InitializeComponent();

            CarregarInformacoes(temas, clientes);

        }

        private void CarregarInformacoes(IRepositorioTema temas, IRepositorioCliente clientes)
        {
            foreach (Tema t in temas.SelecionarTodos())
            {
                cmbBoxTema.Items.Add(t);
            }

            foreach (Cliente c in clientes.SelecionarTodos())
            {
                cmbBoxCliente.Items.Add(c);
            }
        }

        private void cmbBoxTema_SelectedValueChanged(object sender, EventArgs e)
        {
            listaItens.Items.Clear();

            Tema tema = (Tema)cmbBoxTema.SelectedItem;

            foreach (ItemTema item in tema.itens)
            {
                listaItens.Items.Add(item);
            }

        }

        private decimal desconto = 1;

        private void listaItens_SelectedValueChanged(object sender, EventArgs e)
        {
            decimal valorTotal = 0;
            List<ItemTema> itensSelecionados = ObterItensMarcados();
            foreach (ItemTema item in itensSelecionados)
            {
                valorTotal += item.valor;
            }

            valorTotal *= desconto;

            txtValorTotal.Text = valorTotal.ToString();

            decimal valorEntrada = valorTotal * (decimal)0.4;

            txtValorEntrada.Text = valorEntrada.ToString();
        }

        private bool VerificarCliente(Cliente cliente)
        {
            if (cliente.antigo)
                return true;
            return false;
        }

        private void cmbBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = cmbBoxCliente.SelectedItem as Cliente;

            if (VerificarCliente(cliente))
            {
                desconto = (decimal)0.9;
            }

        }

        public Festa ObterFesta()
        {
            int id = Convert.ToInt32(txtId.Text);
            Cliente cliente = (Cliente)cmbBoxCliente.SelectedItem;

            Tema tema = (Tema)cmbBoxTema.SelectedItem;

            string endereco = txtEndereco.Text;

            DateTime data = txtData.Value;
            TimeSpan horaInicio = txtHoraInicio.Value.TimeOfDay;
            TimeSpan horaFim = txtHoraFim.Value.TimeOfDay;

            decimal valorTotal = Convert.ToDecimal(txtValorTotal.Text);
            decimal valorEntrada = Convert.ToDecimal(txtValorEntrada.Text);

            List<ItemTema> itensSelecionados = ObterItensMarcados();

            Festa festa = new Festa(id, cliente, tema, data, horaInicio, horaFim, endereco, valorTotal, valorEntrada, itensSelecionados, false);

            if (id > 0) festa.id = id;

            return festa;
        }

        public List<ItemTema> ObterItensMarcados()
        {
            return listaItens.CheckedItems.Cast<ItemTema>().ToList();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Festa festa = ObterFesta();

            string[] erros = festa.Validar();

            if (false/*erros.Length > 0*/)
            {
                //TelaPrincipal.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }


    }
}
