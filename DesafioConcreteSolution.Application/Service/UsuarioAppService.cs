using DesafioConcreteSolution.Application.DTO;
using DesafioConcreteSolution.Application.Interface.AppService;
using DesafioConcreteSolution.Application.Interface.Service;
using DesafioConcreteSolution.Domain.Interface.Factory;
using DesafioConcreteSolution.Domain.Interface.Infrastructure;

namespace DesafioConcreteSolution.Application.Service
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IUsuarioFactory _usuarioFactory;
        private readonly ISecurityService _securityService;

        public UsuarioAppService(IUsuarioService usuarioService, IUsuarioFactory usuarioFactory, ISecurityService securityService)
        {
            _usuarioService = usuarioService;
            _usuarioFactory = usuarioFactory;
            _securityService = securityService;
        }

        public void SignUp(UsuarioDTO userDTO, string senha)
        {
            senha = _securityService.GerarPBKDF2(senha);
            var usuario = _usuarioFactory.Create(userDTO.nome, userDTO.email, senha, userDTO.telefones);

            _usuarioService.SingUp(usuario);
        }

        public UsuarioDTO Login(string email, string senha)
        {
            senha = _securityService.GerarPBKDF2(senha);
            var usuario = _usuarioService.Login(email, senha);

            var usuarioDTO = new UsuarioDTO();
            usuarioDTO.nome = usuario.Nome;
            usuarioDTO.email = usuario.Email;
            usuario.Telefones?.ForEach(x => usuarioDTO.telefones.Add(x.DDD + x.Numero));

            return usuarioDTO;
        }

        public void Profile(string token)
        {
            
        }
    }
}