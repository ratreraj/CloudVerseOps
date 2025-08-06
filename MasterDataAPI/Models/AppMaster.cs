using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDataAPI.Models
{
    public class AppMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AppCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string AppName { get; set; }

        public string LOBCode { get; set; }
             
        public string Owner { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }
        

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

       
    }
}
