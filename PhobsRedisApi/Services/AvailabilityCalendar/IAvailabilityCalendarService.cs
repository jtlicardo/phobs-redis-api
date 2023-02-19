using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.AvailabilityCalendar
{
    public interface IAvailabilityCalendarService
    {
        public Task<PCAvailabilityCalendarRS?> GetAvailabilityCalendar(AvailabilityCalendarDto request);
    }
}
