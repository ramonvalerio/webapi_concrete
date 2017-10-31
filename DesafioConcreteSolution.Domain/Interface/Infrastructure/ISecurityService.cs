namespace DesafioConcreteSolution.Domain.Interface.Infrastructure
{
    public interface ISecurityService
    {
        string GerarPBKDF2(string valor);
    }
}