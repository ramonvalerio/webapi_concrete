using DesafioConcreteSolution.Domain.Interface.Infrastructure;
using System;
using System.Security.Cryptography;

namespace DesafioConcreteSolution.Infrastructure.Service
{
    public class SecurityService : ISecurityService
    {
        public string GerarPBKDF2(string valor)
        {
            var saltString = "ABCDEF123456";
            var saltBytes = new byte[saltString.Length * sizeof(char)];

            // Copia string padrão de salt para array de bytes
            Buffer.BlockCopy(saltString.ToCharArray(), 0, saltBytes, 0, saltBytes.Length);

            using (var pbkdf2 = new Rfc2898DeriveBytes(valor, saltBytes))
            {
                var pseudoRandomKey = pbkdf2.GetBytes(24);

                return Convert.ToBase64String(pseudoRandomKey);
            }
        }
    }
}
