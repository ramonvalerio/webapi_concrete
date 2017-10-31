using DesafioConcreteSolution.Domain.Interface.Repository;
using DesafioConcreteSolution.Domain.Model;
using DesafioConcreteSolution.Infrastructure.Context;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DesafioConcreteSolution.Infrastructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DesafioConcreteSolutionsContext _context;
        private readonly SqlContext _sqlContext;

        public UsuarioRepository(DesafioConcreteSolutionsContext context, SqlContext sqlContext)
        {
            _context = context;
            _sqlContext = sqlContext;
        }

        public void SignUp(Usuario usuario)
        {
            var sql = new StringBuilder("INSERT INTO USUARIO(NOME, SENHA, EMAIL, TOKEN, DATA_ULTIMO_LOGIN)");
            sql.Append(" VALUES(@NOME, @SENHA, @EMAIL, @TOKEN, @DATA_ULTIMO_LOGIN) SELECT SCOPE_IDENTITY()");

            var userId = _sqlContext.Execute(sql.ToString(),
                new SqlParameter("@NOME", usuario.Nome),
                new SqlParameter("@SENHA", usuario.Senha),
                new SqlParameter("@EMAIL", usuario.Email),

                //new SqlParameter("@TOKEN", usuario.Token ?? string.Empty),
                //new SqlParameter("@DATA_ULTIMO_LOGIN", usuario.DataUltimoLogin)

                new SqlParameter("@TOKEN", DBNull.Value),
                new SqlParameter("@DATA_ULTIMO_LOGIN", DBNull.Value)
                );

            if (usuario.Telefones == null)
                return;

            foreach (var telefone in usuario?.Telefones)
            {
                telefone.UsuarioId = (int)userId;

                var sqlTelefone = new StringBuilder("INSERT INTO TELEFONE(DDD, NUMERO, USUARIO_ID)");
                sql.Append(" VALUES(@DDD, @NUMERO, @USUARIO_ID)");

                _sqlContext.Execute(sqlTelefone.ToString(),
                new SqlParameter("@DDD", telefone.DDD),
                new SqlParameter("@NUMERO", telefone.Numero),
                new SqlParameter("@USUARIO_ID", telefone.UsuarioId)
                );
            }
        }

        public Usuario Login(string email, string senha)
        {
            var usuario = _context.Usuarios.SingleOrDefault(x => x.Email == email && x.Senha == senha);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            usuario.Telefones = _context.Telefones.Where(x => x.UsuarioId == usuario.Id).ToList();

            return usuario;
        }

        public Usuario Profile(int id)
        {
            return _context.Usuarios.SingleOrDefault(x => x.Id == id);
        }

        public bool ExisteEmail(string email)
        {
            var result = _context.Usuarios.SingleOrDefault(x => x.Email == email);
            return result != null;
        }
    }
}