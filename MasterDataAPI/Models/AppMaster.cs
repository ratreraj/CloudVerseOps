using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDataAPI.Models
{
    public class AppMaster
    {
        [Key]
        public int AppId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AppCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string AppName { get; set; }


        [MaxLength(300)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        // Navigation
        public LOBMaster LineOfBusiness { get; set; }
        public ICollection<AppEnvironment> Environments { get; set; }
    }
}
