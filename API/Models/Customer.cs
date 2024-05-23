using System.ComponentModel.DataAnnotations;

namespace prn_dentistry.API.Models
{
  public class Customer
  {
    [Key]
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
    public ICollection<TreatmentPlan> TreatmentPlans { get; set; }
    public ICollection<ChatMessage> SentMessages { get; set; }
  }
}