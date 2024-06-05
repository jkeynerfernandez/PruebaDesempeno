using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;
using PruebaKeyner.DTO;


namespace PruebaKeyner.Controllers.Pets
{
    
    
    public class PetCreateController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetCreateController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost]
        [Route("api/pets/")]
        public IActionResult CrearMascotaa([FromBody] PetCrearDto petDto)
        {
            _petRepository.CrearMascota(petDto);
            return Ok("Mascota exitosamente" );
        }

       
    }
}
