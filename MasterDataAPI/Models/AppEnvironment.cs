using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace MasterDataAPI.Models
{
    public class AppEnvironment
    {
        [Key]
        public int EnvironmentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string EnvironmentName { get; set; } // e.g., Dev, Test, Stage, Prod

        [Required]
        [MaxLength(100)]
        public string ResourceGroup { get; set; } // Optional resource mapping

        [ForeignKey("Application")]
        public int AppId { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        // Navigation
        public AppMaster? Application { get; set; }
    }

}
