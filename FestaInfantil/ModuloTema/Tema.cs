
using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloTema
{
    public class Tema : EntidadeBase<Tema> {

        public string nome;
        public List<ItemTema> itens;

        public Tema(int id, string nome) {
            this.id = id;
            this.nome = nome;
            itens = new List<ItemTema>();
        }

        public override void AtualizarInformacoes(Tema registroAtualizado) {
            id = registroAtualizado.id;
            nome = registroAtualizado.nome;
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }
    }
}
