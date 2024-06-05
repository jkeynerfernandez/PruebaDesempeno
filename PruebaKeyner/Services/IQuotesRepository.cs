using PruebaKeyner.DTO;
using PruebaKeyner.Models;

namespace PruebaKeyner.Services{
    public interface IQuoteRepository{
        void CrearCita(QuoteCrearDto quotetDto);
        IEnumerable<QuoteModel> ListarCitas();
        void ActualizarCita(int id, QuoteCrearDto quoteDto);
        
        QuoteModel ObtenerDetallesDecita(int id);

        //endpoints Medios


        IEnumerable<QuoteModel> ObtenerCitasPorDia( DateTime fecha);

        


    }


}


