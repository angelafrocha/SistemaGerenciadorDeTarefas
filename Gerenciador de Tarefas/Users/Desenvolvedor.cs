using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Tarefas.Users
{
    internal class Desenvolvedor: Usuario,ICargo
    {
        public override string Cargo
        {
            get
            {
                return "Desenvolvedor";
            }
        }

        public Desenvolvedor(string nome, string email, string senha)
            : base(nome, email, senha)
        {
        }

        public List<Tarefa> ObterTarefas()
        {
            return Tarefa.ObterTodasTarefas().Where(t => t.Responsavel == this).ToList();
        }

        public List<Tarefa> ObterTarefasComRelacao()
        {
            return Tarefa.ObterTodasTarefas().Where(t => t.Relacoes.Any(r => r.Responsavel == this)).ToList();
        }

        public void CriarTarefa(string descricao, DateTime dataInicial, DateTime dataFinal)
        {
            Tarefa tarefa = new Tarefa(descricao, dataInicial, dataFinal);

            Tarefa.AdicionarTarefa(tarefa);
        }

        public void AssumirTarefa(int idTarefa)
        {
            Tarefa tarefa = Tarefa.ObterTarefaPorId(idTarefa);
            tarefa.Responsavel = this;
           
            tarefa.Salvar();
        }

        public void IniciarTarefa(int idTarefa)
        {
            //TechLeader techLeader = TechLeader.ObterTechLeader();
            //techLeader.SolicitarInicioTarefa(idTarefa);

            // colocar a tarefa para iniciar
        }

        public static Desenvolvedor ObterDesenvolvedor(string email, string senha)
        {
            // fazer o metodo
            return null;
        }

        public void VerTarefas()
        {
            // mostrar tarefas
        }
    }
}
