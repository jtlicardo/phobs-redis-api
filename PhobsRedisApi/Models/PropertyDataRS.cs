namespace PhobsRedisApi.Models
{

    public class PropertyDataRS
    {
        public string PropertyId { get; set; }
        public float[] Prices { get; set; }
        public int[] Availability { get; set; }
    }

}
