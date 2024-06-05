using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;
using PruebaKeyner.DTO;


namespace PruebaKeyner.Controllers.Quotes
{
    
    
    public class QuoteCreateController : ControllerBase
    {
        private readonly IQuoteRepository _qRepository;

        public QuoteCreateController(IQuoteRepository qRepository)
        {
            _qRepository = qRepository;
        }

        [HttpPost]
        [Route("api/quotes/")]
        public IActionResult CrearCita([FromBody] QuoteCrearDto qDto)
        {
            _qRepository.CrearCita(qDto);
            return Ok("Mascota exitosamente" );
        }

       
    }
}
