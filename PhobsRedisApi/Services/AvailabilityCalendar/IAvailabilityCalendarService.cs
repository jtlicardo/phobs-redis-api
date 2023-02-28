using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.AvailabilityCalendar
{
    public interface IAvailabilityCalendarService
    {
        Task<PCAvailabilityCalendarRS?> GetAvailabilityCalendar(AvailabilityCalendarDto request);
    }
}
