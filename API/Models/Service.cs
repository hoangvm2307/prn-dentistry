using System.ComponentModel.DataAnnotations;

namespace prn_dentistry.API.Models
{
  public class Service
  {
    [Key]
    public int ServiceID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }
    public decimal Price { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
  }
}