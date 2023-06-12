namespace FestaInfantil.Dominio.ModuloFesta
{
    [Serializable]
    public class Festa : EntidadeBase<Festa>
    {
        public string cliente;
        public string tema;
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaFim;
        public string endereco;
        public string valorTotal;
        public string valorEntrada;
        //public Itens itensSelecionados;

        public Festa() { }

        public Festa(string cliente, string tema, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, string endereco, string valorTotal, string valorEntrada)
        {
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.endereco = endereco;
            this.valorTotal = valorTotal;
            this.valorEntrada = valorEntrada;
        }

        public Festa(int id, string cliente, string tema, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, string endereco, string valorTotal, string valorEntrada)
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
        }

        public override string[] Validar()
        {
            return new string[]{};
        }


    }
}
