using System.ComponentModel.DataAnnotations;

namespace PhobsRedisApi.Dtos
{
    public class AvailabilityCalendarDto
    {
        public string PropertyId { get; set; }
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "The StartDate must be in the format YYYY-MM-DD.")]
        [CustomValidation(typeof(AvailabilityCalendarDto), "ValidateDate")]
        public string StartDate { get; set; }
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "The EndDate must be in the format YYYY-MM-DD.")]
        [CustomValidation(typeof(AvailabilityCalendarDto), "ValidateDate")]
        public string EndDate { get; set; }
        public bool ShowUnitDetails { get; set; } = true;
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
