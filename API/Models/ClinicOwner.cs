using System.ComponentModel.DataAnnotations;

namespace prn_dentistry.API.Models
{
  public class ClinicOwner : BaseEntity
  {
    [Key]
    public int OwnerID { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    
    public string Email { get; set; }
    public List<Clinic> Clinics{get;set;}
  }
}