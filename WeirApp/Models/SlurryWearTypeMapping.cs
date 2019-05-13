using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
    [Table("tblSlurryWearTypeMapping")]
    public class SlurryWearTypeMapping
    {
        public int Id { get; set; }
        [Required]
        public int? Industry { get; set; }
        public int? Application { get; set; }
        public int? SlurryType { get; set; }
        public int? SlurryWearType { get; set; }
    }

    public class SlurryWearTypeMappingDTO
    {
        public int Id { get; set; }
        [Required]
        public int? Industry { get; set; }
        public int? Application { get; set; }
        public int? SlurryType { get; set; }
        public int? SlurryWearType { get; set; }
    }
}