using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciador_de_Tarefas.Enums;
using Gerenciador_de_Tarefas.Users;

namespace Gerenciador_de_Tarefas            
{
    public class RelacaoTarefas
    {
        public List<Tarefa> TarefasRelacionadas { get; set; }

        public CorrelacaoTarefaEnum Correlacao { get; set; }

        public ICargo Responsavel { get; set; }

        public RelacaoTarefas(List<Tarefa> tarefasRelacionadas, CorrelacaoTarefaEnum correlacaoTarefa)
        {
            this.TarefasRelacionadas = tarefasRelacionadas;
            this.Correlacao = correlacaoTarefa;
        }

    }
}
