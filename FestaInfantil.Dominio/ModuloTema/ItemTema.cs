namespace FestaInfantil.Dominio.ModuloTema {
    public class ItemTema:EntidadeBase<ItemTema>  {

        public string nome;
        public decimal valor;

        public override void AtualizarInformacoes(ItemTema registroAtualizado) {
            throw new NotImplementedException();
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }
    }
}
