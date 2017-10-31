using DesafioConcreteSolution.Domain.Model;

namespace DesafioConcreteSolution.Application.Interface.Service
{
    public interface IUsuarioService
    {
        void SingUp(Usuario user);

        Usuario Login(string email, string senha);

        void Profile(string token);

        bool ExisteEmail(string email);
    }
}