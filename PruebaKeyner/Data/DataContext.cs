using Microsoft.EntityFrameworkCore;
using PruebaKeyner.Models;

namespace PruebaKeyner.Data{

    public class DataContext : DbContext{

        public DataContext(DbContextOptions<DataContext> options): base(options){

        }

        public DbSet<Vet> Vets {get; set;}
        public DbSet<Owner> Owners {get; set;}
        public DbSet<Pet> Pets {get; set;}
        public DbSet<QuoteModel> Quotes {get; set;}


    }


}