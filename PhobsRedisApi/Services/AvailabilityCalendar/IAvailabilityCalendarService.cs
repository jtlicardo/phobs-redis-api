using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;

namespace PhobsRedisApi.Services.AvailabilityCalendar
{
    public interface IAvailabilityCalendarService
    {
        Task<PCAvailabilityCalendarRS?> GetAvailabilityCalendar(AvailabilityCalendarDto request);
    }
}
