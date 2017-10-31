using DesafioConcreteSolution.Application.DTO;

namespace DesafioConcreteSolution.Application.Interface.AppService
{
    public interface IUsuarioAppService
    {
        void SignUp(UsuarioDTO userDTO, string senha);

        UsuarioDTO Login(string email, string senha);

        void Profile(string token);
    }
}