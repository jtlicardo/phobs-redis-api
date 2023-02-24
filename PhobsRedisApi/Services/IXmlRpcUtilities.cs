namespace PhobsRedisApi.Services
{
    public interface IXmlRpcUtilities
    {
        T DeserializeXmlToObject<T>(string xml);
        Task<HttpResponseMessage> SendHttpRequest(string requestXml, string url);
        string SerializeObjectToXml<T>(T obj);
    }
}