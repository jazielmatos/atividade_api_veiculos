using Microsoft.AspNetCore.Mvc;

namespace atividade_api_web.Controllers
{
    [ApiController]
    [Route("/token")]
    public class TokenController : ControllerBase
    {
        [HttpHead]
        public ActionResult Index()
        {
            return StatusCode(204);
        }
    }
}
