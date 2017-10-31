using DesafioConcreteSolution.Domain.Model;

namespace DesafioConcreteSolution.Domain.Interface.Repository
{
    public interface IUsuarioRepository
    {
        void SignUp(Usuario user);

        Usuario Login(string email, string senha);

        Usuario Profile(int id);

        bool ExisteEmail(string email);
    }
}