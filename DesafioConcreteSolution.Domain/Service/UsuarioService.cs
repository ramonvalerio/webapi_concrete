using System;
using DesafioConcreteSolution.Application.Interface.Service;
using DesafioConcreteSolution.Domain.Interface.Repository;
using DesafioConcreteSolution.Domain.Model;

namespace DesafioConcreteSolution.Domain.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void SingUp(Usuario usuario)
        {
            if (!usuario.IsValid())
                throw new Exception("Usuário inválido");

            if (_usuarioRepository.ExisteEmail(usuario.Email))
                throw new Exception("E-mail informado já existe.");

            _usuarioRepository.SignUp(usuario);
        }

        public Usuario Login(string email, string senha)
        {
            return _usuarioRepository.Login(email, senha); ;
        }

        public void Profile(string token)
        {
            
        }

        public bool ExisteEmail(string email)
        {
            return _usuarioRepository.ExisteEmail(email);
        }
    }
}