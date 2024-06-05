using PruebaKeyner.Data;
using PruebaKeyner.Models;
using PruebaKeyner.DTO;
using Microsoft.EntityFrameworkCore;

namespace PruebaKeyner.Services
{
    public class QuoteRepository : IQuoteRepository{
        private readonly DataContext _context;
        private readonly IEmailService _emailService;
        

        public QuoteRepository (DataContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
      
        }

        public void CrearCita(QuoteCrearDto cDto)
        {
            var quote = new QuoteModel
            {
                Date = cDto.Date,
                PetId = cDto.PetId,
                VetId = cDto.VetId,
                Description = cDto.Description
                
            };

            _context.Quotes.Add(quote);
            _context.SaveChanges();

            var pet = _context.Pets.Find(cDto.PetId);
            var vet = _context.Vets.Find(cDto.VetId);

            if (pet != null && vet != null)
            {
                var subject = "Cuida atu animalito";
                var mensajePaciente = $"Hola {pet.Owner},\nTienes una nueva cita programada para el {cDto.Date}.";
               
                _emailService.SendEmail("juankeyner@hotmail.com", subject, mensajePaciente);
                
            }

        }

        public IEnumerable<QuoteModel> ListarCitas()
        {
            return _context.Quotes.Include(p=> p.Pet).Include(v=> v.Vet).ToList();
        }

        public QuoteModel ObtenerDetallesDecita(int id)
        {
            return _context.Quotes.FirstOrDefault(q => q.Id==id);
        }

        public void ActualizarCita(int id,  QuoteCrearDto cDto)
        {
            var existentQuote = _context.Quotes.Find(id);
            if (existentQuote != null)
            {
                existentQuote.Date = cDto.Date;
                existentQuote.PetId = cDto.PetId;
                existentQuote.VetId = cDto.VetId;
                existentQuote.Description =cDto.Description;
               

                _context.SaveChanges();
            }
        }

        //adicional
        public IEnumerable<QuoteModel> ObtenerCitasPorDia(DateTime fecha)
        {
            return _context.Quotes.Where(q =>  q.Date.Date == fecha.Date)
                                 .Include(p => p.Pet)
                                 .ToList();
        }

        





    }
   
    
}