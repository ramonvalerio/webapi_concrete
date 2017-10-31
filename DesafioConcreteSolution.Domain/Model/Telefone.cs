using DesafioConcreteSolution.Domain.Interface.Model;

namespace DesafioConcreteSolution.Domain.Model
{
    public class Telefone : IValueObject
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string DDD { get; set; }
        public int UsuarioId { get; set; }
    }
}