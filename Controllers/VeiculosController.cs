using atividade_api_web.Models;
using atividade_api_web.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace atividade_api_web.Controllers
{
    [Route("veiculos")]
    public class VeiculosController : ControllerBase
    {
        // GET: Veiculos
        [HttpGet("")]
        public IActionResult Index()
        {
            var veiculos = VeiculoRepositorio.Instancia().Lista;
            return StatusCode(200, veiculos);
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            var veiculo = VeiculoRepositorio.Instancia().Lista.Find(c => c.Id == id);

            return StatusCode(200, veiculo);
        }

        // POST: Veiculos
        [HttpPost("")]
        public IActionResult Create([FromBody] Veiculo veiculo)
        {
            VeiculoRepositorio.Instancia().Lista.Add(veiculo);
            return StatusCode(201, veiculo);
        }


        // PUT: Veiculos/5
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] Veiculo veiculo)
        {
            if (id != veiculo.Id)
            {
                return StatusCode(400, new
                {
                    Mensagem = "O Id do veiculo precisa bater com o id da URL"
                });
            }

            var veiculoDb = VeiculoRepositorio.Instancia().Lista.Find(c => c.Id == id);
            if (veiculoDb is null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "O veiculo informado não existe"
                });
            }

            veiculoDb.Id = veiculo.Id;
            veiculoDb.Nome = veiculo.Nome;
            veiculoDb.Descricao = veiculo.Descricao;
            veiculoDb.Modelo = veiculo.Modelo;
            veiculoDb.Marca = veiculo.Marca;
            veiculoDb.Ano = veiculo.Ano;

            return StatusCode(200, veiculoDb);
        }

        // POST: Veiculos/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var veiculoDb = VeiculoRepositorio.Instancia().Lista.Find(c => c.Id == id);
            if (veiculoDb is null)
            {
                return StatusCode(404, new
                {
                    Mensagem = "O veiculo informado não existe"
                });
            }

            VeiculoRepositorio.Instancia().Lista.Remove(veiculoDb);

            return RedirectToAction(nameof(Index));
        }
    }
}