using System.ComponentModel.DataAnnotations;

namespace Linq01.Models
{
    public class Context
    {
        [Required]
        public string? Medal { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Sport { get; set; }
        [Required]
        [Range(0,100000000)]
        public int PrizeMoney { get; set; }

    }
}
