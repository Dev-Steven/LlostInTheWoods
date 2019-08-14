using System.ComponentModel.DataAnnotations;
namespace lostInTheWoods.Models
{
    public class Trail
    {
        [Key]
        public long Id { get; set; }
 
        [Required]
        public string Name { get; set; }
 
        [Required]
        [MinLength(10)]
        public string Description { get; set; }
 
        [Required]
        public double? Distance { get; set; }

        [Required]
        public double? Elevation { get; set; }

        [Required]
        public string Longitude {get; set; }

        [Required]
        public string Latitude {get; set; }

    }
}