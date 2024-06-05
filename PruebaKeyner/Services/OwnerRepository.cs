using PruebaKeyner.Data;
using PruebaKeyner.Models;
using Microsoft.EntityFrameworkCore;
using PruebaKeyner.DTO;

namespace PruebaKeyner.Services
{
    public class OwnerRepository : IOwnerRepository{
        private readonly DataContext _context;
        

        public OwnerRepository (DataContext context)
        {
            _context = context;
      
        }

         public IEnumerable<Owner> ListarDuenos()
        {
            return _context.Owners.ToList();
        }

        public void crearOwner(OwnerCrearDto crearDto)
        {
            var owner = new Owner
            {
                Names = crearDto.Names,
                LastNames = crearDto.LastNames,
                Phone = crearDto.Phone,
                Address =crearDto.Address,
                Email=crearDto.Email
            };

            _context.Owners.Add(owner);
            _context.SaveChanges();
        }

         public void ActualizarDueno(int id, OwnerCrearDto owner)
        {
            var existentOwner = _context.Owners.Find(id);
            if (existentOwner != null)
            {
                existentOwner.Names = owner.Names;
                existentOwner.LastNames = owner.LastNames;
                existentOwner.Phone = owner.Phone;
                existentOwner.Address =owner.Address;
                existentOwner.Email=owner.Email;
                

                _context.SaveChanges();
            }
        }


        





    }
   
    
}