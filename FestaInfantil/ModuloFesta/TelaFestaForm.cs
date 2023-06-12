using FestaInfantil.Dominio.ModuloFesta;

namespace FestaInfantil.ModuloFesta
{
    public partial class TelaFestaForm : Form
    {
        public TelaFestaForm()
        {
            InitializeComponent();
        }

        public Festa ObterFesta()
        {
            int id = Convert.ToInt32(txtId);
            string cliente = cmbBoxCliente.Text;
            string tema = cmbBoxTema.Text;
            string endereco = txtEndereco.Text;

            DateTime data = txtData.Value;
            TimeSpan horaInicio = txtHoraInicio.Value.TimeOfDay;
            TimeSpan horaFim = txtHoraFim.Value.TimeOfDay;

            string valorTotal = txtValorTotal.Text;
            string valorEntrada = txtValorEntrada.Text;

            Festa festa = new Festa(id, cliente, tema, data, horaInicio, horaFim, endereco, valorTotal, valorEntrada);

            if (id > 0) festa.id = id;

            return festa;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Festa festa = ObterFesta();

            string[] erros = festa.Validar();

            if (erros.Length > 0)
            {
                //TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
