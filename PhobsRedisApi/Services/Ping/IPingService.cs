using PhobsRedisApi.Dtos;
using PhobsRedisApi.PhobsModels;

namespace PhobsRedisApi.Services.Ping
{
    public interface IPingService
    {
        Task<PCPingRS?> PingRemoteServer(PingDto request);
    }
}
