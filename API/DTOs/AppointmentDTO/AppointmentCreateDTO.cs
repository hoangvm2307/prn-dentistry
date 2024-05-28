namespace prn_dentistry.API.DTOs.AppointmentDTO
{
  public class AppointmentCreateDTO
  {
    public int CustomerID { get; set; }
    public int DentistID { get; set; }
    public int ServiceID { get; set; }
    public DateTime AppointmentDate { get; set; }
    public DateTime AppointmentTime { get; set; }
    public string Status { get; set; }
  }

}