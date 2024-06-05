using PruebaKeyner.Models;
using PruebaKeyner.DTO;

namespace PruebaKeyner.Services{
    public interface IOwnerRepository{
        IEnumerable<Owner> ListarDuenos();
        void crearOwner (OwnerCrearDto ownwer);

        void ActualizarDueno(int id, OwnerCrearDto owner);
    }


}