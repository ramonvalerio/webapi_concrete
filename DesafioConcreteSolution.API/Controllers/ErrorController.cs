using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace DesafioConcreteSolution.API.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet, HttpPost, HttpPut, HttpDelete, HttpHead, HttpOptions, AcceptVerbs("PATCH")]
        public HttpResponseMessage Handle404()
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.NotFound);
            responseMessage.ReasonPhrase = "Url inválida ou não foi encontrada";

            return responseMessage;
        }
    }
}