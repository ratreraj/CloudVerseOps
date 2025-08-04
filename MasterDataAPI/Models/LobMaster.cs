using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace MasterDataAPI.Models
{
    public class LOBMaster
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public string LOBCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string LOBName { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        // Navigation
        public ICollection<AppMaster> Applications { get; set; }
    }
}
