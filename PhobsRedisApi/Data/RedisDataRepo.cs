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

        public void SaveData(string key, string value, TimeSpan? expirationInMinutes = null)
        { 
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Key is null or empty", nameof(key));
            }

            var db = _redis.GetDatabase();
            
            var expiration = expirationInMinutes ?? TimeSpan.FromMinutes(60);

            db.StringSet(key, value, expiration);
        }

        public void PushToList(string key, string value)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Key is null or empty", nameof(key));
            }

            var db = _redis.GetDatabase();

            RedisType keyType = db.KeyType(key);

            if (keyType != RedisType.None && keyType != RedisType.List)
            {
                db.KeyDelete(key);
            }

            db.ListRightPush(key, value);
        }

        public void SetExpiration(string key, TimeSpan expirationTime)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Key is null or empty", nameof(key));
            }

            var db = _redis.GetDatabase();

            db.KeyExpire(key, expirationTime);
        }

        public string[] GetList(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Key is null or empty", nameof(key));
            }

            var db = _redis.GetDatabase();

            var data = db.ListRange(key);

            if (data != null)
            {
                return data.ToStringArray();
            }

            return null;
        }

    }
}
