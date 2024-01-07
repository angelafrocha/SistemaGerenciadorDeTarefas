using Gerenciador_de_Tarefas.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Tarefas.Users
{
    internal class TechLeader: Usuario,ICargo
    {
        public override string Cargo
        {
            get
            {
                return "Tech Leader";
            }
        }

        public TechLeader(string nome, string email, string senha)
          : base(nome, email, senha)
        {
        }



        public void CriarTarefa(string descricao, DateTime dataInicial, DateTime dataFinal)
        {
            
            
        }

        public void AssumirTarefa(int idTarefa)
        {
           
        }

        public void ColocarResponsavel(int idTarefa, int idUsuario)
        {
        
            Tarefa tarefa = Tarefa.ObterTarefaPorId(idTarefa);

            Usuario usuario = Usuario.ObterUsuarioPorId(idUsuario);

            tarefa.Responsavel = usuario;


            tarefa.Salvar();
        }

        public void IniciarTarefa(int idTarefa)
        {
            Tarefa tarefa = Tarefa.ObterTarefaPorId(idTarefa);

            tarefa.Status = StatusTarefaEnum.EmAndamento;


            tarefa.Salvar();
        }

        public static TechLeader ObterTechLeader(string email, string senha) 
        {
            // fazer o metodo
            return null;
        }

        public void VerTarefas()
        {
            // mostrar tarefas
        }

        public void ExibirEstatisticas()
        { 
            // mostrar estatisticas
        }

        public void SolicitarInicioTarefa(int idTarefa)
        {
            throw new NotImplementedException();
        }
    }
}
