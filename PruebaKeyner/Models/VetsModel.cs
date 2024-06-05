/*
CREATE TABLE Vets (
    
    Id int AUTO_INCREMENT NOT NULL PRIMARY KEY,
    Name VARCHAR(120),
    Phone VARCHAR(25),
    Address VARCHAR(30),
    Email VARCHAR(100) UNIQUE

);

*/

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PruebaKeyner.Models{
        public  class  Vet {
            
            
            [Required]
            public int Id {get; set ;}
            [Required]
            public string  Name {get; set ;}
            [Required]
            public string  Phone {get; set ;}
            [Required]
            public string  Address {get; set ;}
            [Required]
            public string  Email {get; set ;}
            [JsonIgnore]
            public List<QuoteModel> Quotes {get; set ;} //un veterinario puede tener muchas citas 


    



        }


} 