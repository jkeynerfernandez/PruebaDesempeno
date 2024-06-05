using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;
using PruebaKeyner.DTO;
using PruebaKeyner.Models;


namespace PruebaKeyner.Controllers.Owners
{
    
    
    public class OwnerUdateController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerUdateController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        [HttpPut]
        [Route("api/owner/{id}")]
        public ActionResult<Owner> ActualizarDueno(int id, OwnerCrearDto owner)
        {
            _ownerRepository.ActualizarDueno(id, owner);
            return Ok(owner);
        }

       
    }
}
