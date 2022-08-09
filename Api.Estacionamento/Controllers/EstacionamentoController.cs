using Api.Estacionamento.Models.DTOs;
using Api.Estacionamento.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


namespace Api.Estacionamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstacionamentoController : ControllerBase
    {
        private IEstacionamentoService _service { get; set; }

        public EstacionamentoController(IEstacionamentoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetVeiculos([FromQuery] int id)
        {
            try
            {
                var data = await _service.GetVeiculos(id);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);

            }
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarEntrada([FromBody] VeiculoDTO veiculo)
        {
            try
            {
                var response = await _service.CadastroVeiculo(veiculo);

                if (response) return NoContent();

                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);

            }
        }

    }
}
