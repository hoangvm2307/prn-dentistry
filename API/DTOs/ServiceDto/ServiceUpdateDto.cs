using System.ComponentModel.DataAnnotations;

namespace prn_dentistry.API.DTOs.ServiceDto
{
  public class ServiceUpdateDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public int Duration { get; set; }
        
        [Required]
        public decimal Price { get; set; }
    }
}