using System.ComponentModel.DataAnnotations;

namespace marketDb.Models
{
    public class Urun
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim Giriniz")]
        public string Name { get; set; }
        [Range(0,150,ErrorMessage ="Fiyat aralığın dışında")]
        public decimal Price { get; set; }
        [Required]
        public bool IsStock { get; set; }
    }
}
