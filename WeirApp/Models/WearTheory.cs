using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
    [Table("tblWearTheory")]
    public class WearTheory
    {
        public int Id { get; set; }
        [Required]
        public int? SlurryWearType { get; set; }
        public int? HeadDuties { get; set; }
        public int? ComponentType { get; set; }
        public string ProcessApplications { get; set; }
        public string PumpModels { get; set; }
        public string PartSelection { get; set; }
        public string SWTDescription { get; set; }
        public string HeadDutyDescription { get; set; }
        public string ComponentDecription { get; set; }
        public string WearLifeGuardeRange { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
        public byte[] Image3 { get; set; }
        public byte[] Image4 { get; set; }
        public byte[] Image5 { get; set; }
        public byte[] Image6 { get; set; }
        public byte[] Image7 { get; set; }
        public byte[] Image8 { get; set; }
        public byte[] Image9 { get; set; }
        public byte[] Image10 { get; set; }
    }

    public class WearTheoryDTO
    {
        public int Id { get; set; }
        [Required]
        public int? SlurryWearType { get; set; }
        public int? HeadDuties { get; set; }
        public int? ComponentType { get; set; }
        public string ProcessApplications { get; set; }
        public string PumpModels { get; set; }
        public string PartSelection { get; set; }
        public string SWTDescription { get; set; }
        public string HeadDutyDescription { get; set; }
        public string ComponentDecription { get; set; }
        public string WearLifeGuardeRange { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
        public byte[] Image3 { get; set; }
        public byte[] Image4 { get; set; }
        public byte[] Image5 { get; set; }
        public byte[] Image6 { get; set; }
        public byte[] Image7 { get; set; }
        public byte[] Image8 { get; set; }
        public byte[] Image9 { get; set; }
        public byte[] Image10 { get; set; }
    }
}