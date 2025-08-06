using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace MasterDataAPI.Models
{
    public class LOBMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string LOBCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string LOBName { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
        [JsonIgnore]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;


    }
}
