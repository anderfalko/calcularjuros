using Microsoft.AspNetCore.Mvc;
using ProvaTecnica.Calculos;

namespace ProvaTecnica.API.Controllers
{
    [ApiController]
    public class CalculosController : ControllerBase
    {
        /// <summary>
        /// Calcula os Juros
        /// </summary>
        /// <param name="valorinicial">Valor inicial</param>
        /// <param name="meses">Quantidade de meses</param>
        /// <returns></returns>
        [HttpGet("api/[action]")]
        public double calculajuros(double valorinicial, int meses)
        {
            CalculosJuros calc = new CalculosJuros();
            double valor = calc.CalcurarJuros(valorinicial, meses);
            return valor;
        }

        /// <summary>
        /// Redireciona para o código-fonte do projeto
        /// </summary>
        [HttpGet("api/[action]")]
        public void showmethecode()
        {
            Response.Redirect("https://github.com/anderfalko/calcularjuros");
        }
    }
}