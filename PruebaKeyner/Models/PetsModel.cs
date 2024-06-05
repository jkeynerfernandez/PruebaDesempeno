/*
CREATE TABLE  Pets (
    
   	Id int AUTO_INCREMENT NOT NULL PRIMARY KEY,
    Name VARCHAR(25),
    Specie ENUM,
    Race   ENUM,
    DateBirth DATE,
    OwnerId INT,
    Photo TEXT,
    FOREIGN KEY(OwnerId) REFERENCES Owners(Id)
    
);

*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PruebaKeyner.Models{
        public  class  Pet{
            
            
            [Required]
            public int Id {get; set ;}
            [Required]
            public string?  Name {get; set ;}
            [Required]
             public string?  Specie {get; set ;}
             [Required]
            public string?  Race {get; set ;}
            [Required]
            public DateTime  DateBirth {get; set ;}
            [Required]
            [ForeignKey("OwnerId") ]
            public int?  OwnerId {get; set ;}
            public Owner Owner {get; set ;} // muchas mascotas tienen un solo dueño
            [JsonIgnore]
            public List<QuoteModel> Quotes {get; set ;} //una mascota puede tener muchas citas 

            public string?  Photo {get; set ;}


    



        }


} 