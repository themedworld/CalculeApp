using Microsoft.AspNetCore.Mvc;

namespace MonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculController : ControllerBase
    {
        [HttpGet("add")]
        public string Addition(double a, double b) =>"la resultat de l'addition est:"+ (a + b).ToString();

        [HttpGet("sub")]
        public string Soustraction(double a, double b) =>"la resultat de soustraction est" +(a - b).ToString();

        [HttpGet("mul")]
        public string Multiplication(double a, double b) => "la resultat de multiplication est "+(a * b).ToString();

        [HttpGet("div")]
        public ActionResult<string> Division(double a, double b)
        {
            if (b == 0)
                return BadRequest("Erreur : division par zéro !");
            return "la resultat de la division est :"+(a / b).ToString();
        }
    }
}
