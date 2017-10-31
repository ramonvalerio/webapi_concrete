using DesafioConcreteSolution.API.Models;
using DesafioConcreteSolution.Application.DTO;
using DesafioConcreteSolution.Application.Interface.AppService;
using DesafioConcreteSolution.Infrastructure.DI;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DesafioConcreteSolution.API.Controllers
{
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController()
        {
            _usuarioAppService = DesafioConcreteSolutionsKernel.Get<IUsuarioAppService>();
        }

        [HttpPut]
        public HttpResponseMessage SignUp(string nome, string email, string senha, string[] telefones)
        {
            var usuarioDTO = new UsuarioDTO();
            usuarioDTO.nome = nome;
            usuarioDTO.email = email;
            usuarioDTO.telefones = telefones?.ToList();

            try
            {
                _usuarioAppService.SignUp(usuarioDTO, senha);
                return Request.CreateResponse(HttpStatusCode.Created, true);
            }
            catch (Exception ex)
            {
                var errorMessage = new ErrorMessage("1", ex.Message);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, errorMessage);
            }
        }

        [HttpGet]
        public HttpResponseMessage Login(string email, string senha)
        {
            try
            {
                var usuarioDTO = _usuarioAppService.Login(email, senha);
                return Request.CreateResponse(HttpStatusCode.OK, usuarioDTO);
            }
            catch (Exception ex)
            {
                var errorMessage = new ErrorMessage("1", ex.Message);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, errorMessage);
            }
        }

        [HttpGet]
        public HttpResponseMessage Profile(string token)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "profile teste");
            }
            catch (Exception ex)
            {
                var errorMessage = new ErrorMessage("1", ex.Message);
                return Request.CreateResponse(HttpStatusCode.InternalServerError, errorMessage);
            }
        }
    }
}