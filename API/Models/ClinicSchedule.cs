using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prn_dentistry.API.Models
{
  public class ClinicSchedule
  {
    [Key]
    public int ScheduleID { get; set; }

    [ForeignKey("Clinic")]
    public int ClinicID { get; set; }
    public Clinic Clinic { get; set; }

    public string DayOfWeek { get; set; }
    public DateTime OpeningTime { get; set; }
    public DateTime ClosingTime { get; set; }
    public int SlotDuration { get; set; }
    public int MaxPatientsPerSlot { get; set; }
  }
}