using System.Collections.Generic;

namespace DesafioConcreteSolution.Application.DTO
{
    public class UsuarioDTO
    {
        public string nome { get; set; }

        public string email { get; set; }

        public IList<string> telefones { get; set; }

        public UsuarioDTO()
        {
            telefones = new List<string>();
        }
    }
}