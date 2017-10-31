using DesafioConcreteSolution.Domain.Model;
using System.Collections.Generic;

namespace DesafioConcreteSolution.Domain.Interface.Factory
{
    public interface IUsuarioFactory
    {
        Usuario Create(string nome, string email, string senha, IList<string> telefones);
    }
}