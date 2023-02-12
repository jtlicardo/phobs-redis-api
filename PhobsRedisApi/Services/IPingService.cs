using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.Dtos;

namespace PhobsRedisApi.Services
{
    public interface IPingService
    {
        public Task<string> PingRemoteServer(PingDto request);
    }
}
