using Microsoft.AspNetCore.Mvc;

namespace MonApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculController : ControllerBase
    {
        [HttpGet("add")]
        public double Addition(double a, double b) => a + b;

        [HttpGet("sub")]
        public double Soustraction(double a, double b) => a - b;

        [HttpGet("mul")]
        public double Multiplication(double a, double b) => a * b;

        [HttpGet("div")]
        public ActionResult<double> Division(double a, double b)
        {
            if (b == 0)
                return BadRequest("Erreur : division par zéro !");
            return a / b;
        }
    }
}
