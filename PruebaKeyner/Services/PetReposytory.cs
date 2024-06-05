using PruebaKeyner.Data;
using PruebaKeyner.Models;
using PruebaKeyner.DTO;
using Microsoft.EntityFrameworkCore;

namespace PruebaKeyner.Services
{
    public class PetRepository : IPetRepository{
        private readonly DataContext _context;
        

        public PetRepository (DataContext context)
        {
            _context = context;
      
        }

        public void CrearMascota(PetCrearDto petDto)
        {
            var pet = new Pet
            {
                Name = petDto.Name,
                Specie = petDto.Specie,
                Race = petDto.Race,
                DateBirth =petDto.DateBirth,
                OwnerId=petDto.OwnerId,
                Photo=petDto.Photo
            };

            _context.Pets.Add(pet);
            _context.SaveChanges();
        }

        public IEnumerable<Pet> ListarMascotas()
        {
            return _context.Pets.Include(o => o.Owner).ToList();
        }

        public Pet ObtenerMascotaPorId(int id)
        {
            return _context.Pets.FirstOrDefault(p => p.Id==id);
        }

        public void ActualizarMascota(int id,  PetCrearDto petDto)
        {
            var existentPet = _context.Pets.Find(id);
            if (existentPet != null)
            {
                existentPet.Name = petDto.Name;
                existentPet.Specie = petDto.Specie;
                existentPet.Race = petDto.Race;
                existentPet.DateBirth =petDto.DateBirth;
                existentPet.OwnerId=petDto.OwnerId;
                existentPet.Photo=petDto.Photo;

                _context.SaveChanges();
            }
        }
        //adicional 
        public IEnumerable<Pet> ObtenerMascotasDeDueño(int ownerId)
        {
            return _context.Pets.Where(p => p.OwnerId == ownerId).ToList();
        }

        public IEnumerable<Pet> ObtenerMascotasPorCumple(DateTime fecha)
        {
            return _context.Pets.Where(p => p.DateBirth.Date == fecha.Date).ToList();
        }

        





    }
   
    
}