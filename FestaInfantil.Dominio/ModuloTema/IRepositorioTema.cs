namespace FestaInfantil.Dominio.ModuloTema {
    public interface IRepositorioTema {
        void Inserir(Tema novoTema);
        void Editar(int id, Tema tema);
        void Excluir(Tema temaSelecionado);
        Tema SelecionarPorId(int id);
        List<Tema> SelecionarTodos();
        
    }
}
