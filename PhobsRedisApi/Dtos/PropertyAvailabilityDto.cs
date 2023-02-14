namespace PhobsRedisApi.Dtos
{
    public class PropertyAvailabilityDto
    {
        public string[] PropertyIds { get; set; }
        public string Date { get; set; }
        public byte Nights { get; set; }
        public byte Adults { get; set; }
        public byte ChdGroup1 { get; set; }
        public byte ChdGroup2 { get; set; }
        public byte Pets { get; set; }
        public byte Age { get; set; }
        public bool PriceBreakdown { get; set; }
        public string[] AccessCodes { get; set; }
        public string Lang { get; set; }
    }
}
