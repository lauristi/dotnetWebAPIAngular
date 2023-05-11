using Microsoft.AspNetCore.Mvc;
using System.Net;
using webapi.Services.Interfaces.BrazilianFloraService;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrazilianFloraController : ControllerBase
    {
        public readonly IBrazilianFloraService _brazilianFloraService;

        public BrazilianFloraController(IBrazilianFloraService brazilianFloraService)
        {
            _brazilianFloraService = brazilianFloraService;
        }

        [HttpGet("families")]
        public async Task<IActionResult> GetFamilies()
        {
            var response = await _brazilianFloraService.GetFamilies();

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpGet("genus/{family}")]
        public async Task<IActionResult> GetGenus(string family)
        {
            var response = await _brazilianFloraService.GetGenus(family);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpGet("species/{family}")]
        public async Task<IActionResult> GetSpecies(string family)
        {
            var response = await _brazilianFloraService.GetSpecies(family);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpGet("taxon/{scientificName}")]
        public async Task<IActionResult> GetTaxon(string scientificName)
        {
            var response = await _brazilianFloraService.GetTaxon(scientificName);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }


    }
}