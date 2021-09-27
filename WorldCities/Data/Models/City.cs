using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCities.Data.Models
{
    [Table("Cities")]
    public class City
    {
        public City()
        {}     
        
        [Key]
        [Required]
        public int Id {get; set;}
        public string Name {get; set;}
        public string Name_ASCII {get; set;}
        public decimal Lat {get; set;}
        public decimal Lon {get; set;}
        
        [ForeignKey(nameof(Country))]
        public int CountryId {get; set;}
        public virtual Country Country {get; set;}
    }
}