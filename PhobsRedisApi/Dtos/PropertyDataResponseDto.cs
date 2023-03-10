namespace PhobsRedisApi.Dtos
{
    public class PropertyDataResponseDto
    {
        public string PropertyId { get; set; }
        public float? MinPricePerDay { get; set; }
        public bool? Availability { get; set; }
    }

}
