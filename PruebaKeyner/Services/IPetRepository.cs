using PruebaKeyner.DTO;
using PruebaKeyner.Models;

namespace PruebaKeyner.Services{
    public interface IPetRepository{
        void CrearMascota(PetCrearDto petDto);
        IEnumerable<Pet> ListarMascotas();
        void ActualizarMascota(int id, PetCrearDto petDto);
        
        Pet ObtenerMascotaPorId(int id);

        //adicional
        IEnumerable<Pet> ObtenerMascotasDeDueño(int ownerId);
        IEnumerable<Pet> ObtenerMascotasPorCumple(DateTime fecha);


        
    }
    


}



  