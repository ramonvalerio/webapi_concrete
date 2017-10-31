namespace DesafioConcreteSolution.API.Models
{
    public class ErrorMessage
    {
        public string statusCode { get; set; }
        public string mensagem { get; set; }

        public ErrorMessage(string statusCode, string mensagem)
        {
            this.statusCode = statusCode;
            this.mensagem = mensagem;
        }
    }
}