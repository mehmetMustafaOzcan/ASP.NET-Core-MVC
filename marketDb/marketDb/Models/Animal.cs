using System.ComponentModel.DataAnnotations;
using System.Web;
namespace marketDb.Models
{
    public class Animal
    {
        //[Editable(false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genus { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
       // [Range(typeof(DateTime),"01-01-2010", "01-01-2030")]
        public DateTime Birthdate { get; set; }
      
        public string Description { get; set; }
      
        public string? Photopath { get; set; }
    }
}
