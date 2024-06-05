using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;

using PruebaKeyner.Models;


namespace PruebaKeyner.Controllers.Quotes
{
    
    
    public class QuoteListarController : ControllerBase
    {
        private readonly IQuoteRepository _qRepository;

        public QuoteListarController(IQuoteRepository qRepository)
        {
            _qRepository = qRepository;
        }

        [HttpGet]
        [Route("api/quotes/")]
        public ActionResult<IEnumerable<QuoteModel>> ListarCitas()
        {
            try
            {
                var q = _qRepository.ListarCitas();
                return Ok(q);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener la lista de citas: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("api/quotes/{id}")]
        public ActionResult<QuoteModel> ObtenerDetallesDecita(int id)
        {
            try
            {
                var q = _qRepository.ObtenerDetallesDecita(id);
                if (q == null)
                {
                    return NotFound($"cita con id {id} no encontrada");
                }

                return Ok(q);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener el cita : {ex.Message}");
            }
        }

       
    }
}
