using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;

using PruebaKeyner.Models;


namespace PruebaKeyner.Controllers.Pets
{
    
    
    public class PetListarController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetListarController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpGet]
        [Route("api/pets/")]
        public ActionResult<IEnumerable<Pet>> ListaDeMascotas()
        {
            try
            {
                var pet = _petRepository.ListarMascotas();
                return Ok(pet);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener la lista de mascotasa: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("api/pets/{id}")]
        public ActionResult<Pet> ObtenerVeteribarioPorId(int id)
        {
            try
            {
                var pet = _petRepository.ObtenerMascotaPorId(id);
                if (pet == null)
                {
                    return NotFound($"mascota con id {id} no encontrada");
                }

                return Ok(pet);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener el mAscota: {ex.Message}");
            }
        }


        //adicionales


        [HttpGet]
        [Route("api/pets/{id}/owner")]
        public ActionResult<Pet> ObtenerMascotasDeDueño(int id)
        {
            try
            {
                var pet = _petRepository.ObtenerMascotasDeDueño(id);

                return Ok(pet);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener las mascotad: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("api/pets/{date}/birthday")]
        public ActionResult<Pet> ObtenerMascotasPorCumple(DateTime fecha)
        {
            try
            {
                var pet = _petRepository.ObtenerMascotasPorCumple(fecha);

                return Ok(pet);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener las mascotaa: {ex.Message}");
            }

        }
    }
}
