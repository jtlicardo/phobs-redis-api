using System.Text;
using System.Xml.Serialization;

namespace PhobsRedisApi.Services
{
    public class XmlRpcUtilities
    {
        private readonly IHttpClientFactory _clientFactory;

        public XmlRpcUtilities(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public string SerializeObjectToXml<T>(T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                xmlSerializer.Serialize(memoryStream, obj, ns);
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
        public async Task<HttpResponseMessage> SendHttpRequest(string requestXml, string url)
        {
            var client = _clientFactory.CreateClient();
            StringContent content = new StringContent(requestXml, Encoding.UTF8, "text/xml");
            return await client.PostAsync(url, content);
        }

        public T DeserializeXmlToObject<T>(string xml)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                return (T)deserializer.Deserialize(reader);
            }
        }
    }
}
