namespace FestaInfantil.Dominio.ModuloTema {
    [Serializable]
    public class ItemTema:EntidadeBase<ItemTema>  {

        public string nome;
        public decimal valor;

        public ItemTema(string nome, decimal valor) {
            this.nome = nome;
            this.valor = valor;
        }

        public ItemTema() {

        }

        public override string ToString() {
            return nome + " - R$: " + valor;
        }

        public override void AtualizarInformacoes(ItemTema registroAtualizado) {
            throw new NotImplementedException();
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }
    }
}
