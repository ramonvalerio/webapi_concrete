using DesafioConcreteSolution.Application.DTO;
using DesafioConcreteSolution.Application.Interface.AppService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioConcreteSolution.Test.ApplicationService
{
    [TestClass]
    public class UserAppServiceTest
    {
        private readonly IUsuarioAppService _userAppService;

        public UserAppServiceTest(IUsuarioAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [TestMethod]
        public void SingUp_User()
        {
            var userDTO = new UsuarioDTO();
            //_userAppService.SignUp(userDTO);
        }

        [TestMethod]
        public void Login()
        {
            var userDTO = new UsuarioDTO();
            //_userAppService.SignUp(userDTO);
        }

        [TestMethod]
        public void Profile()
        {
            var userDTO = new UsuarioDTO();
            //_userAppService.SignUp(userDTO);
        }
    }
}
