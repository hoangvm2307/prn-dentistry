using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using prn_dentistry.API.DTOs.AppointmentDTO;
using prn_dentistry.API.Models;
using prn_dentistry.API.Repositories;

namespace prn_dentistry.API.Services
{
  public class AppointmentService : IAppointmentService
  {
    private readonly IAppointmentRepository _appointmentRepository;
    private readonly IMapper _mapper;

    public AppointmentService(IAppointmentRepository appointmentRepository, IMapper mapper)
    {
      _appointmentRepository = appointmentRepository;
      _mapper = mapper;
    }
    public async Task<IEnumerable<AppointmentDTO>> GetAllAppointmentsAsync()
    {
      var appointments = await _appointmentRepository.GetAllAppointmentsAsync();
      return _mapper.Map<IEnumerable<AppointmentDTO>>(appointments);
    }

    public async Task<AppointmentDTO> GetAppointmentByIdAsync(int id)
    {
      var appointment = await _appointmentRepository.GetAppointmentByIdAsync(id);
      if (appointment == null)
        return null;

      return _mapper.Map<AppointmentDTO>(appointment);
    }

    public async Task<AppointmentDTO> CreateAppointmentAsync(AppointmentCreateDTO appointmentCreateDTO)
    {
      var appointment = _mapper.Map<Appointment>(appointmentCreateDTO);
      await _appointmentRepository.AddAppointmentAsync(appointment);

      return _mapper.Map<AppointmentDTO>(appointment);
    }

    public async Task<AppointmentDTO> UpdateAppointmentAsync(int id, AppointmentUpdateDTO appointmentUpdateDTO)
    {
      var appointment = await _appointmentRepository.GetAppointmentByIdAsync(id);
      if (appointment == null)
        return null;

      _mapper.Map(appointmentUpdateDTO, appointment);
      await _appointmentRepository.UpdateAppointmentAsync(appointment);

      return _mapper.Map<AppointmentDTO>(appointment);
    }

    public async Task<bool> DeleteAppointmentAsync(int id)
    {
      var appointment = await _appointmentRepository.GetAppointmentByIdAsync(id);
      if (appointment == null)
        return false;

      await _appointmentRepository.DeleteAppointmentAsync(id);
      return true;
    }
  }
}