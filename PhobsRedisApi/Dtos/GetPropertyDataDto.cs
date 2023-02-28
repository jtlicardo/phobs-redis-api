using System.ComponentModel.DataAnnotations;

namespace PhobsRedisApi.Dtos
{
    public class GetPropertyDataDto
    {
        public string Property { get; set; }
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "The Date must be in the format YYYY-MM-DD.")]
        [CustomValidation(typeof(AvailabilityCalendarDto), "ValidateDate")]
        public byte Adults { get; set; }
        public byte Chd { get; set; }
        public byte Pets { get; set; }
        public string Rate { get; set; }
        public string Date { get; set; }
        public byte Nights { get; set; }
      
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
