using Microsoft.AspNetCore.Mvc;
using PruebaKeyner.Services;
using PruebaKeyner.DTO;
using PruebaKeyner.Models;


namespace PruebaKeyner.Controllers.Quotes
{
    
    
    public class QuoteUdateController : ControllerBase
    {
        private readonly IQuoteRepository _quoteRepository;

        public QuoteUdateController(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;
        }

        [HttpPut]
        [Route("api/quotes/{id}")]
        public ActionResult<QuoteModel> ActualizarCita(int id, QuoteCrearDto qDto)
        {
            _quoteRepository.ActualizarCita(id, qDto);
            return Ok(qDto);
        }

       
    }
}
