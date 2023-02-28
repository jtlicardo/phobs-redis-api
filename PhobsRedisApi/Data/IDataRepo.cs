namespace PhobsRedisApi.Data
{
    public interface IDataRepo
    {
        void SaveData(string key, string value, TimeSpan? expirationTime = null);
        string? GetData(string key);
        void PushToList(string key, string value);
        void SetExpiration(string key, TimeSpan expirationTime);
        string[] GetList(string key);
    }
}
