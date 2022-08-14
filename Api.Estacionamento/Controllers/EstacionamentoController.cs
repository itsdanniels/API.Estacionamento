using Api.Estacionamento.Models.DTOs;
using Api.Estacionamento.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Api.Estacionamento.Utils;
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
        public async Task<IActionResult> GetVeiculoNoPatio([FromQuery] string placa)
        {
            if (string.IsNullOrWhiteSpace(placa)) return BadRequest("Placa não pode ser nulo.");
            try
            {
                var data = await _service.GetVeiculoNoPatio(placa);
                
                if(data != null) return Ok(data);

                return NotFound();
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

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public async Task<IActionResult> SaidaVeiculo([FromQuery] string placa)
        {
            try
            {
                var response = await _service.SaidaVeiculo(placa);

                if (response) return NoContent();

                return BadRequest();

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
