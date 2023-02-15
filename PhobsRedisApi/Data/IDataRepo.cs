namespace PhobsRedisApi.Data
{
    public interface IDataRepo
    {
        void SaveData(string key, string value);
        string? GetData(string key);
    }
}
