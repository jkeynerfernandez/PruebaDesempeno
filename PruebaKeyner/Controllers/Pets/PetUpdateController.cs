using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;
using PruebaKeyner.DTO;
using PruebaKeyner.Models;


namespace PruebaKeyner.Controllers.Pets
{
    
    
    public class PetUdateController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetUdateController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPut]
        [Route("api/pets/{id}")]
        public ActionResult<Pet> ActualizarMascota(int id, PetCrearDto petDto)
        {
            _petRepository.ActualizarMascota(id, petDto);
            return Ok(petDto);
        }

       
    }
}
