using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prn_dentistry.API.Models
{
  public class ClinicOwner
  {
    [Key]
    public int OwnerID { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    [ForeignKey("Clinic")]
    public int ClinicID { get; set; }
    public Clinic Clinic { get; set; }
  }
}