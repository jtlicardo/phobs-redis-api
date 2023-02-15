using StackExchange.Redis;

namespace PhobsRedisApi.Data
{
    public class RedisDataRepo : IDataRepo
    {

        private readonly IConnectionMultiplexer _redis;

        public RedisDataRepo(IConnectionMultiplexer redis)
        {
            _redis = redis;
        }
        
        public string? GetData(string key)
        {         
            var db = _redis.GetDatabase();

            var data = db.StringGet(key);

            if (!string.IsNullOrEmpty(data))
            {
                return data.ToString();
            }
                
            return null;
        }

        public void SaveData(string key, string value)
        { 
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Key is null or empty", nameof(key));
            }

            var db = _redis.GetDatabase();

            db.StringSet(key, value);
        }
    }
}
