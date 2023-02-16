namespace PhobsRedisApi.Data
{
    public interface IDataRepo
    {
        void SaveData(string key, string value, TimeSpan? expirationTime = null);
        string? GetData(string key);
    }
}
