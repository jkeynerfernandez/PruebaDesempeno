using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;
using PruebaKeyner.Models;
using PruebaKeyner.DTO;


namespace PruebaKeyner.Controllers.Owners
{
    
    
    public class OwnerCreateController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerCreateController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        [HttpPost]
        [Route("api/owners")]
        public IActionResult CrearDueno([FromBody] OwnerCrearDto ownerDto)
        {
            _ownerRepository.crearOwner(ownerDto);
            return Ok("Dueño exitosamente" );
        }

       
    }
}
