using FestaInfantil.Dominio.ModuloCliente;
using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.Dominio.ModuloFesta
{
    [Serializable]
    public class Festa : EntidadeBase<Festa>
    {
        public Cliente cliente;
        public Tema tema;
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaFim;
        public string endereco;
        public string valorTotal;
        public string valorEntrada;
        public List<ItemTema> itensSelecionados;

        public Festa() { }

        public Festa(Cliente cliente, Tema tema, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, string endereco, string valorTotal, string valorEntrada, List<ItemTema> itensSelecionados)
        {
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.endereco = endereco;
            this.valorTotal = valorTotal;
            this.valorEntrada = valorEntrada;
            this.itensSelecionados = itensSelecionados;
        }

        public Festa(int id, Cliente cliente, Tema tema, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, string endereco, string valorTotal, string valorEntrada, List<ItemTema> itensSelecionados)
        {
            this.id = id;
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.endereco = endereco;
            this.valorTotal = valorTotal;
            this.valorEntrada = valorEntrada;
            this.itensSelecionados = itensSelecionados;
        }

        public override void AtualizarInformacoes(Festa registroAtualizado)
        {
            cliente = registroAtualizado.cliente;
            tema = registroAtualizado.tema;
            data = registroAtualizado.data;
            horaInicio = registroAtualizado.horaInicio;
            horaFim = registroAtualizado.horaFim;
            endereco = registroAtualizado.endereco;
            valorTotal = registroAtualizado.valorTotal;
            valorEntrada = registroAtualizado.valorEntrada;
            itensSelecionados = registroAtualizado.itensSelecionados;
        }

        public override string[] Validar()
        {
            return new string[]{};
        }


    }
}
