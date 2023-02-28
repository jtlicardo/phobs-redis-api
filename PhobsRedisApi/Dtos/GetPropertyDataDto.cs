using System.ComponentModel.DataAnnotations;

namespace PhobsRedisApi.Dtos
{
    public class GetPropertyDataDto
    {
        public string Property { get; set; }
        public byte Adults { get; set; }
        public byte Chd { get; set; }
        public byte Pets { get; set; }
        public string Rate { get; set; }
        public string Date { get; set; }
        public byte Nights { get; set; }
     
    }
}
