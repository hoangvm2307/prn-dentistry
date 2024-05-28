namespace prn_dentistry.API.DTOs.AppointmentDTO
{
  public class AppointmentUpdateDTO
  {
    public int AppointmentID { get; set; }
    public DateTime? AppointmentDate { get; set; }
    public DateTime? AppointmentTime { get; set; }
    public string Status { get; set; }
  }
}