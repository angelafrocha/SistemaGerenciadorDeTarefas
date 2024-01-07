using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Tarefas.Users
{
    public abstract class Usuario
    {
        protected Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }

        public abstract string Cargo { get; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

        public void AtualizarSenha(string novaSenha)
        {
            this.Senha = novaSenha;
        }

        protected static Usuario ObterUsuarioPorId(int idUsuario)
        {
            // fazer busca por ID
            return null;
        }
    }
}
