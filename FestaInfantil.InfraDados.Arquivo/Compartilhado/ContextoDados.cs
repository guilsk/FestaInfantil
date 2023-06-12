using System.Text.Json.Serialization;
using System.Text.Json;

using FestaInfantil.Dominio.ModuloTema;

namespace FestaInfantil.InfraDados.Arquivo.Compartilhado
{
    public class ContextoDados //container
    {
        private const string NOME_ARQUIVO = "Compartilhado\\FestaInfantil.json";

        public List<Tema> temas;

        //public List<Compromisso> compromissos;

        //public List<Tarefa> tarefas;

        //public List<Categoria> categorias;

        //public List<Despesa> despesas;

        public ContextoDados()
        {
            temas = new List<Tema>();
            //compromissos = new List<Compromisso>();
            //tarefas = new List<Tarefa>();
            //categorias = new List<Categoria>();
            //despesas = new List<Despesa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    this.temas = ctx.temas;
                    //this.compromissos = ctx.compromissos;
                    //this.tarefas = ctx.tarefas;
                    //this.categorias = ctx.categorias;
                    //this.despesas = ctx.despesas;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
