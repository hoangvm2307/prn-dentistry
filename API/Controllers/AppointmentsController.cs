using Microsoft.AspNetCore.Mvc;
using prn_dentistry.API.DTOs.AppointmentDTO;
using prn_dentistry.API.Services;

namespace prn_dentistry.API.Controllers
{
  public class AppointmentsController : BaseApiController
  {
    private readonly IAppointmentService _appointmentService;

    public AppointmentsController(IAppointmentService appointmentService)
    {
      _appointmentService = appointmentService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppointmentDTO>>> GetAllAppointments()
    {
      var appointments = await _appointmentService.GetAllAppointmentsAsync();
      return Ok(appointments);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AppointmentDTO>> GetAppointment(int id)
    {
      var appointment = await _appointmentService.GetAppointmentByIdAsync(id);

      if (appointment == null)
        return NotFound();

      return Ok(appointment);
    }

    [HttpPost]
    public async Task<ActionResult<AppointmentDTO>> CreateAppointment(AppointmentCreateDTO appointmentCreateDTO)
    {
      var appointment = await _appointmentService.CreateAppointmentAsync(appointmentCreateDTO);
      return CreatedAtAction(nameof(GetAppointment), new { id = appointment.AppointmentID }, appointment);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAppointment(int id, AppointmentUpdateDTO appointmentUpdateDTO)
    {
      var appointment = await _appointmentService.UpdateAppointmentAsync(id, appointmentUpdateDTO);

      if (appointment == null)
        return NotFound();

      return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAppointment(int id)
    {
      var success = await _appointmentService.DeleteAppointmentAsync(id);

      if (!success)
        return NotFound();

      return NoContent();
    }
  }
}