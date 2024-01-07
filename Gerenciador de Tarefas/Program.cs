using Gerenciador_de_Tarefas.Users;

namespace Gerenciador_de_Tarefas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipoUsuario;
            string email;
            string senha;

            
            Console.WriteLine("Qual é o seu tipo de usuário?");
            Console.WriteLine("1 - Tech Leader");
            Console.WriteLine("2 - Desenvolvedor");
            tipoUsuario = Console.ReadLine();

            switch (tipoUsuario)
            {
                case "1":
                    
                    Console.WriteLine("Informe o seu e-mail:");
                    email = Console.ReadLine();
                    Console.WriteLine("Informe a sua senha:");
                    senha = Console.ReadLine();

                    
                    TechLeader techLeader = TechLeader.ObterTechLeader(email, senha);
                    if (techLeader == null)
                    {
                        Console.WriteLine("E-mail ou senha inválidos.");
                        break;
                    }

                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("1 - Ver tarefas");
                    Console.WriteLine("2 - Criar tarefa");
                    Console.WriteLine("3 - Assumir tarefa");
                    Console.WriteLine("4 - Iniciar tarefa");
                    Console.WriteLine("5 - Estatísticas");
                    int opcaoTech = int.Parse(Console.ReadLine());

                    switch (opcaoTech)
                    {
                        case 1:
                            techLeader.VerTarefas();
                            break;
                        case 2:
                            // deve receber descricao e dataFim
                            string descricao = "teste";

                            techLeader.CriarTarefa(descricao, System.DateTime.Now, System.DateTime.Now);
                            break;
                        case 3:
                            //deve receber o ID da tarefa
                            int idAssumirTarefa = 1;
                            techLeader.AssumirTarefa(idAssumirTarefa);
                            break;
                        case 4:
                            //deve receber o ID da tarefa
                            int idIniciarTarefa = 1;
                            techLeader.IniciarTarefa(idIniciarTarefa);
                            break;
                        case 5:
                            techLeader.ExibirEstatisticas();
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Informe o seu e-mail:");
                    email = Console.ReadLine();
                    Console.WriteLine("Informe a sua senha:");
                    senha = Console.ReadLine();

                    Desenvolvedor desenvolvedor = Desenvolvedor.ObterDesenvolvedor(email, senha);
                    if (desenvolvedor == null)
                    {
                        Console.WriteLine("E-mail ou senha inválidos.");
                        break;
                    }

                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("1 - Ver tarefas");
                    Console.WriteLine("2 - Criar tarefa");
                    Console.WriteLine("3 - Assumir tarefa");
                    Console.WriteLine("4 - Iniciar tarefa");
                    int opcaoDev = int.Parse(Console.ReadLine());

                    switch (opcaoDev)
                    {
                        case 1:
                            desenvolvedor.VerTarefas();
                            break;
                        case 2:
                            // deve receber descricao e dataFim

                            desenvolvedor.CriarTarefa(descricao, System.DateTime.Now, System.DateTime.Now);
                            break;
                        case 3:
                            //deve receber o ID da tarefa
                            int idAssumirTarefa = 1;
                            desenvolvedor.AssumirTarefa(idAssumirTarefa);
                            break;
                        case 4:
                            //deve receber o ID da tarefa
                            int idIniciarTarefa = 1;
                            desenvolvedor.IniciarTarefa(idIniciarTarefa);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo de usuário inválido.");
                    break;
            }
        }
    }
}