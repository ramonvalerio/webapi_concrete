using DesafioConcreteSolution.Domain.Interface.Model;
using System;
using System.Collections.Generic;

namespace DesafioConcreteSolution.Domain.Model
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime? DataUltimoLogin { get; set; }

        public string Token { get; set; }

        public List<Telefone> Telefones { get; set; }

        private Usuario()
        {

        }

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefones = new List<Telefone>();
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                return false;

            if (string.IsNullOrWhiteSpace(Email))
                return false;

            if (string.IsNullOrWhiteSpace(Senha))
                return false;

            return true;
        }
    }
}