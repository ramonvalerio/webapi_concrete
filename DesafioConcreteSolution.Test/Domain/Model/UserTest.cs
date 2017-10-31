using DesafioConcreteSolution.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioConcreteSolution.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserWithName_NULLOrEMPTY()
        {
            var user = new Usuario(null, "ramonvalerios@gmail.com", "123456");
            Assert.IsTrue(string.IsNullOrWhiteSpace(user.Nome));
        }

        [TestMethod]
        public void User_VALID()
        {
            var user = new Usuario("Ramon Valerio", "ramonvalerios@gmail.com", "123456");
            Assert.IsTrue(user.IsValid());
        }

        [TestMethod]
        public void User_INVALID()
        {
            var user = new Usuario("Ramon Valerio", null, "123456");
            Assert.IsFalse(user.IsValid());
        }
    }
}