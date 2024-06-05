using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;
using PruebaKeyner.Models;


namespace PruebaKeyner.Controllers.Vets
{
    
    
    public class VetConsultarController : ControllerBase
    {
        private readonly IVetRepository _vetRepository;

        public VetConsultarController(IVetRepository vetRepository)
        {
            _vetRepository = vetRepository;
        }

        [HttpGet]
        [Route("api/vets/")]
        public ActionResult<IEnumerable<Vet>> ListaDeMedicos()
        {
            try
            {
                var vet = _vetRepository.ListarVeterinarios();
                return Ok(vet);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener la lista de veterinarios: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("api/vets/{id}")]
        public ActionResult<Vet> ObtenerVeteribarioPorId(int id)
        {
            try
            {
                var vet = _vetRepository.ObtenerVeterinarioPorId(id);
                if (vet == null)
                {
                    return NotFound($"vetrinario con id {id} no encontrado");
                }

                return Ok(vet);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener el veterinario: {ex.Message}");
            }
        }
    }
}
