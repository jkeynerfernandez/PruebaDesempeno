/*
CREATE TABLE Quotes (
    Id int AUTO_INCREMENT NOT NULL PRIMARY KEY,
	Date DATETIME,
    PetId int,
    VetId int,
    Description TEXT,
    FOREIGN KEY(PetId) REFERENCES Pets(Id),
    FOREIGN KEY(VetId) REFERENCES Vets(Id)
    
);
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaKeyner.Models{
        public  class  QuoteModel{
            
            
            [Required]
            public int Id {get; set ;}
            [Required]
            public DateTime  Date {get; set ;}
            [Required]
            [ForeignKey("PetId")]
            public int  PetId {get; set ;}
            public Pet Pet {get; set ;} // una cita solo puede tener una mascota 
            public Vet Vet {get; set ;} // una cita solo puede tener un veterinario

            [Required]
            [ForeignKey("VetId")]
            public int  VetId {get; set ;}
            [Required]
            public string   Description {get; set ;}


            
    



        }


} 