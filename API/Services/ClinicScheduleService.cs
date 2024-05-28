using AutoMapper;
using prn_dentistry.API.DTOs.ClinicScheduleDto;
using prn_dentistry.API.Models;
using prn_dentistry.API.Repositories;

namespace prn_dentistry.API.Services
{
  public class ClinicScheduleService : IClinicScheduleService
  {
    private readonly IClinicScheduleRepository _clinicScheduleRepository;
    private readonly IMapper _mapper;

    public ClinicScheduleService(IClinicScheduleRepository clinicScheduleRepository, IMapper mapper)
    {
      _clinicScheduleRepository = clinicScheduleRepository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<ClinicScheduleDto>> GetAllClinicSchedulesAsync()
    {
      var clinicSchedules = await _clinicScheduleRepository.GetAllClinicSchedulesAsync();
      return _mapper.Map<IEnumerable<ClinicScheduleDto>>(clinicSchedules);
    }

    public async Task<ClinicScheduleDto> GetClinicScheduleByIdAsync(int id)
    {
      var clinicSchedule = await _clinicScheduleRepository.GetClinicScheduleByIdAsync(id);
      return _mapper.Map<ClinicScheduleDto>(clinicSchedule);
    }

    public async Task<ClinicScheduleDto> CreateClinicScheduleAsync(ClinicScheduleCreateDto clinicScheduleCreateDto)
    {
      var clinicSchedule = _mapper.Map<ClinicSchedule>(clinicScheduleCreateDto);
      await _clinicScheduleRepository.AddClinicScheduleAsync(clinicSchedule);
      return _mapper.Map<ClinicScheduleDto>(clinicSchedule);
    }

    public async Task<ClinicScheduleDto> UpdateClinicScheduleAsync(int id, ClinicScheduleUpdateDto clinicScheduleUpdateDto)
    {
      var clinicSchedule = await _clinicScheduleRepository.GetClinicScheduleByIdAsync(id);
      if (clinicSchedule == null)
      {
        return null;
      }

      _mapper.Map(clinicScheduleUpdateDto, clinicSchedule);
      await _clinicScheduleRepository.UpdateClinicScheduleAsync(clinicSchedule);

      return _mapper.Map<ClinicScheduleDto>(clinicSchedule);
    }
    public async Task<bool> DeleteClinicScheduleAsync(int id)
    {
      var clinicSchedule = await _clinicScheduleRepository.GetClinicScheduleByIdAsync(id);
      if (clinicSchedule == null)
      {
        return false;
      }

      await _clinicScheduleRepository.DeleteClinicScheduleAsync(id);
      return true;
    }
  }
}