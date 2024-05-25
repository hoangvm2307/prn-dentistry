using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace prn_dentistry.API.Models
{
  public class Clinic : BaseEntity
  {
    [Key]
    public int ClinicID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime OpeningHours { get; set; }
    public DateTime ClosingHours { get; set; }

    public int OwnerID { get; set; }
    [ForeignKey("OwnerID")]
    public ClinicOwner ClinicOwner { get; set; }
    public List<Dentist> Dentists { get; set; }
    public List<ClinicSchedule> ClinicSchedules { get; set; }
  }
}