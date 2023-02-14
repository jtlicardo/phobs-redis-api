using PhobsRedisApi.Dtos;
using PhobsRedisApi.Models;

namespace PhobsRedisApi.Services.Ping
{
    public interface IPingService
    {
        public Task<PCPingRS> PingRemoteServer(PingDto request);
    }
}
