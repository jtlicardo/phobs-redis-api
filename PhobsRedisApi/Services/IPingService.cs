using PhobsRedisApi.Dtos;
using PhobsRedisApi.XmlRpc;

namespace PhobsRedisApi.Services
{
    public interface IPingService
    {
        public Task<PCPingRS> PingRemoteServer(PingDto request);
    }
}
