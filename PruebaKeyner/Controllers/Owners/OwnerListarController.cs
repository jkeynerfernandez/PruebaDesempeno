using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;
using PruebaKeyner.Models;


namespace PruebaKeyner.Controllers.Owners
{
    
    
    public class OwnerListarController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerListarController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        [HttpGet]
        [Route("api/owners/")]
        public ActionResult<IEnumerable<Owner>> ListaDeDuenos()
        {
            try
            {
                var Owner = _ownerRepository.ListarDuenos();
                return Ok(Owner);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener la lista de dueños : {ex.Message}");
            }
        }

       
    }
}
