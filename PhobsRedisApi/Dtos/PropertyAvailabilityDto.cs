using System.ComponentModel.DataAnnotations;

namespace PhobsRedisApi.Dtos
{
    public class PropertyAvailabilityDto
    {
        public string[] PropertyIds { get; set; }
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "The Date must be in the format YYYY-MM-DD.")]
        [CustomValidation(typeof(AvailabilityCalendarDto), "ValidateDate")]
        public string Date { get; set; }
        public byte Nights { get; set; }
        public string[] RateIds { get; set; } = { };
        public string[] UnitIds { get; set; } = { };
        public byte Adults { get; set; }
        public byte ChdGroup1 { get; set; }
        public byte ChdGroup2 { get; set; }
        public byte Pets { get; set; }
        public byte Age { get; set; }
        public bool PriceBreakdown { get; set; }
        public string[] AccessCodes { get; set; }
        public string Lang { get; set; }

        public static ValidationResult? ValidateDate(string date, ValidationContext context)
        {
            if (!DateTime.TryParse(date, out _))
            {
                return new ValidationResult($"{context.DisplayName} is not a valid date.");
            }

            return ValidationResult.Success;
        }
    }
}
