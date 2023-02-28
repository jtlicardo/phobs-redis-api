using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.Ping
{
    public interface IPingService
    {
        Task<PCPingRS?> PingRemoteServer(PingDto request);
    }
}
