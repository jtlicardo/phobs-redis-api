namespace PhobsRedisApi.Dtos
{
    public class AvailabilityCalendarDto
    {
        public string PropertyId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool ShowUnitDetails { get; set; }
        public string Lang { get; set; }
    }
}
