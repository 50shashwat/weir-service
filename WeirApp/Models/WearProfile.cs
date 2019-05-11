using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
    [Table("tblProfile")]
    public class WearProfile
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int ProductLine { get; set; }
        public int Industry { get; set; }
        public int Process { get; set; }
        public int Customer { get; set; }
        public int SlurryWearType { get; set; }
        public int HeadDuties { get; set; }
        public int PumpType { get; set; }
        public int PumpModel { get; set; }
        public int PumpSize { get; set; }
        public int DischargeOrientation { get; set; }
        public int Impeller { get; set; }
        public int DiameterRatio { get; set; }
        public int ComponentType { get; set; }
        public int PartLife { get; set; }
        public int QBepPer { get; set; }
        public int EfficiencyPer { get; set; }
        public int Solids { get; set; }
        public int D50 { get; set; }
        public int D85 { get; set; }
        public int ParticleShape { get; set; }

        public ICollection<WearProfileCollateral> Collaterals { get; set; }
    }

    public class WearProfileDTO
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int ProductLine { get; set; }
        public int Industry { get; set; }
        public int Process { get; set; }
        public int Customer { get; set; }
        public int SlurryWearType { get; set; }
        public int HeadDuties { get; set; }
        public int PumpType { get; set; }
        public int PumpModel { get; set; }
        public int PumpSize { get; set; }
        public int DischargeOrientation { get; set; }
        public int Impeller { get; set; }
        public int DiameterRatio { get; set; }
        public int ComponentType { get; set; }
        public int PartLife { get; set; }
        public int QBepPer { get; set; }
        public int EfficiencyPer { get; set; }
        public int Solids { get; set; }
        public int D50 { get; set; }
        public int D85 { get; set; }
        public int ParticleShape { get; set; }
        public ICollection<WearProfileCollateral> Collaterals { get; set; }
    }

    [Table("tblProfileCollateral")]
    public class WearProfileCollateral
    {

        public int Id { get; set; }
        [Required]
        public int ProfileId { get; set; }

        public byte[] Collateral { get; set; }

        public WearProfile WearProfile { get; set; }
    }

    public class WearProfileCollateralDTO
    {

        public int Id { get; set; }
        [Required]
        public int ProfileId { get; set; }

        public byte[] Collateral { get; set; }

        public WearProfileDTO WearProfile { get; set; }

    }
}