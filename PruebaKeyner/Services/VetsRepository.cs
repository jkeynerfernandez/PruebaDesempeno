using PruebaKeyner.Data;
using PruebaKeyner.Models;
using Microsoft.EntityFrameworkCore;

namespace PruebaKeyner.Services
{
    public class VetsRepository : IVetRepository{
        private readonly DataContext _context;
        

        public VetsRepository (DataContext context)
        {
            _context = context;
      
        }

         public IEnumerable<Vet> ListarVeterinarios()
        {
            return _context.Vets.ToList();
        }

        public Vet ObtenerVeterinarioPorId(int id)
        {
            return _context.Vets.FirstOrDefault(v => v.Id ==id);
        }





    }
   
    
}