using System.ComponentModel.DataAnnotations;

namespace prn_dentistry.API.DTOs.ClinicScheduleDto
{
  public class ClinicScheduleCreateDto
  {
    [Required]
    public int ClinicID { get; set; }

    [Required]
    public string DayOfWeek { get; set; }

    [Required]
    public DateTime OpeningTime { get; set; }

    [Required]
    public DateTime ClosingTime { get; set; }

    [Required]
    public int SlotDuration { get; set; }

    [Required]
    public int MaxPatientsPerSlot { get; set; }
  }
}