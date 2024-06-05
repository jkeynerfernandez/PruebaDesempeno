using PruebaKeyner.Models;

namespace PruebaKeyner.Services{
    public interface IVetRepository{
        IEnumerable<Vet> ListarVeterinarios();
        Vet ObtenerVeterinarioPorId(int id); 
    }


}