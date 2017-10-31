using DesafioConcreteSolution.Domain.Interface.Factory;
using DesafioConcreteSolution.Domain.Model;
using System.Collections.Generic;

namespace DesafioConcreteSolution.Domain.Factory
{
    public class UsuarioFactory : IUsuarioFactory
    {
        public Usuario Create(string nome, string email, string senha, IList<string> telefones)
        {
            return new Usuario(nome, email, senha);
        }
    }
}