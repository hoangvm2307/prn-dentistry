using System.ComponentModel.DataAnnotations;

namespace prn_dentistry.API.DTOs.TreatmentPlanDto
{
  public class TreatmentPlanUpdateDto
  {
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Frequency { get; set; }
    public DateTime NextAppointmentDate { get; set; }
    [MaxLength(50)]
    public string Status { get; set; }
    [MaxLength(50)]
    public string PaymentStatus { get; set; }
  }
}