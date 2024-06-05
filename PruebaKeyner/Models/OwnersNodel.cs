/*
CREATE TABLE Owners (
    
    Id int AUTO_INCREMENT NOT null PRIMARY KEY,
    Names VARCHAR(50),
    LastNames VARCHAR(50),
    Email VARCHAR(100) UNIQUE,
    Address VARCHAR,
    Phone VARCHAR(25)
    
    
);


*/

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PruebaKeyner.Models{
        public  class  Owner {
            
            
            [Required]
            public int Id {get; set ;}
            [Required]
            public string  Names {get; set ;}
            [Required]
             public string  LastNames {get; set ;}
             [Required]
            public string  Phone {get; set ;}
            [Required]
            public string  Address {get; set ;}
            [Required]
            public string  Email {get; set ;}
            [JsonIgnore]
            public List<Pet> Pets {get; set ;} //un dueño puede tener muchas mascotas 
    



        }


} 