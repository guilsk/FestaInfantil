﻿namespace FestaInfantil.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema> {

        public string nome;
        public List<ItemTema> itens;

        public Tema(int id, string nome) {
            this.id = id;
            this.nome = nome;
            itens = new List<ItemTema>();
        }

        public Tema() {
           
        }

        public void LimparListaItens() {
            itens.Clear();
        }

        public void AdicionarItem(ItemTema item) {
            itens.Add(item);
        }

        public void RemoverItem(ItemTema item) {
            itens.Remove(item);
        }


        public override void AtualizarInformacoes(Tema registroAtualizado) {
            id = registroAtualizado.id;
            nome = registroAtualizado.nome;
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return nome;
        }
    }
}
