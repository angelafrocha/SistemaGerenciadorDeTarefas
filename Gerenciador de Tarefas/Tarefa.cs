using Gerenciador_de_Tarefas.Enums;
using Gerenciador_de_Tarefas.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Tarefas
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public Usuario Responsavel { get; set; }
        public StatusTarefaEnum Status { get; set; }
        public List<RelacaoTarefas> Relacoes { get; set; }
        public string? Caminho { get; set; }

        private static List<Tarefa> tarefasJsonConvertido = new List<Tarefa>();

        public Tarefa(string jsonFile = "ArquivoTarefas.json", DateTime dataInicial = default, DateTime dataFinal = default)
        {
            Caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFile);
            Caminho = Caminho.Replace("Usuarios\\bin\\Debug\\net7.0", "Tarefas");

            tarefasJsonConvertido = JsonService.LerObjeto<List<Tarefa>>(Caminho);

            Relacoes = new List<RelacaoTarefas>();
        }

        public void Iniciar()
        {

            int index = tarefasJsonConvertido.FindIndex(t => t.Id == this.Id);
            if (index == -1)
            {
                throw new Exception("A tarefa não existe.");
            }

            tarefasJsonConvertido[index].Status = StatusTarefaEnum.EmAndamento;

            Salvar();
        }

        public void Concluir()
        {
            int index = tarefasJsonConvertido.FindIndex(t => t.Id == this.Id);
            if (index == -1)
            {
                throw new Exception("A tarefa não existe.");
            }
            tarefasJsonConvertido[index].Status = StatusTarefaEnum.Concluida;

            Salvar();
        }

        public void AdicionarRelacao(CorrelacaoTarefaEnum correlacao)
        {
            int index = tarefasJsonConvertido.FindIndex(t => t.Id == this.Id);
            if (index == -1)
            {
                throw new Exception("A tarefa não existe.");
            }
            tarefasJsonConvertido[index].Relacoes.Add(new RelacaoTarefas(tarefasJsonConvertido, correlacao));

            Salvar();
        }

        public void Salvar()
        {
            int index = tarefasJsonConvertido.FindIndex(t => t.Id == this.Id);

            if (index == -1)
            {
                tarefasJsonConvertido.Add(this);
            }
            else
            {
                tarefasJsonConvertido[index] = this;
            }


            string json = JsonConvert.SerializeObject(tarefasJsonConvertido);
           
            JsonService.SalvarObjeto("tarefas.json", json);
        }
        public static List<Tarefa> ObterTodasTarefas()
        {
            return tarefasJsonConvertido;
        }
        public static Tarefa ObterTarefaPorId(int idTarefa)
        {
            return tarefasJsonConvertido.FirstOrDefault(t => t.Id == idTarefa);
        }

        public static void AdicionarTarefa(Tarefa tarefa)
        {
            // metodo para adicionar tarefa
        }
    }

}
