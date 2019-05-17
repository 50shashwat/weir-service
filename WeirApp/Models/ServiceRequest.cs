using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
  [Table("tblServiceRequest")]
  public class ServiceRequest
  {
    public int Id { get; set; }
    [Required]
    public int? SlurryWearType { get; set; }
    public int? Industry { get; set; }
    public int? Application { get; set; }
    public int? SlurryType { get; set; }
    public int? HeadDuties { get; set; }
    public int? PumpType { get; set; }
    public int? ComponentType { get; set; }
    public string PumpModel { get; set; }
    public string PumpSize { get; set; }
    public string DischargeOrientation { get; set; }
    public string Impeller { get; set; }
    public string DiameterRatio { get; set; }

    public int? PartLife { get; set; }
    public int? QBepPer { get; set; }
    public int? EfficiencyPer { get; set; }
    public string Solids { get; set; }
    public int? D50 { get; set; }
    public int? D85 { get; set; }
    public string ParticleShape { get; set; }
    public string Primary { get; set; }
    public string Secondary { get; set; }
    public string Suggestion { get; set; }
    public string RelatedWearPart { get; set; }
    public byte[] Image1 { get; set; }
    public string ImageFilePath1 { get; set; }
    public byte[] Image2 { get; set; }
    public string ImageFilePath2 { get; set; }
    public byte[] Image3 { get; set; }
    public string ImageFilePath3 { get; set; }
    public byte[] Image4 { get; set; }
    public string ImageFilePath4 { get; set; }
    public byte[] Image5 { get; set; }
    public string ImageFilePath5 { get; set; }

    public byte[] Image6 { get; set; }
    public string ImageFilePath6 { get; set; }

    public byte[] Image7 { get; set; }
    public string ImageFilePath7 { get; set; }

    public byte[] Image8 { get; set; }
    public string ImageFilePath8 { get; set; }

    public byte[] Image9 { get; set; }
    public string ImageFilePath9 { get; set; }

    public byte[] Image10 { get; set; }
    public string ImageFilePath10 { get; set; }

    public int? UserId { get; set; }

  }

  [Table("tblServiceRequestStaging")]
  public class ServiceRequestStaging
  {
    public int Id { get; set; }
    [Required]
    public int? SlurryWearType { get; set; }
    public int? Industry { get; set; }
    public int? Application { get; set; }
    public int? SlurryType { get; set; }
    public int? HeadDuties { get; set; }
    public int? PumpType { get; set; }
    public int? ComponentType { get; set; }
    public string PumpModel { get; set; }
    public string PumpSize { get; set; }
    public string DischargeOrientation { get; set; }
    public string Impeller { get; set; }
    public string DiameterRatio { get; set; }

    public int? PartLife { get; set; }
    public int? QBepPer { get; set; }
    public int? EfficiencyPer { get; set; }
    public string Solids { get; set; }
    public int? D50 { get; set; }
    public int? D85 { get; set; }
    public string ParticleShape { get; set; }
    public string Primary { get; set; }
    public string Secondary { get; set; }
    public string Suggestion { get; set; }
    public string RelatedWearPart { get; set; }
    public byte[] Image1 { get; set; }
    public string ImageFilePath1 { get; set; }
    public byte[] Image2 { get; set; }
    public string ImageFilePath2 { get; set; }
    public byte[] Image3 { get; set; }
    public string ImageFilePath3 { get; set; }
    public byte[] Image4 { get; set; }
    public string ImageFilePath4 { get; set; }
    public byte[] Image5 { get; set; }
    public string ImageFilePath5 { get; set; }

    public byte[] Image6 { get; set; }
    public string ImageFilePath6 { get; set; }

    public byte[] Image7 { get; set; }
    public string ImageFilePath7 { get; set; }

    public byte[] Image8 { get; set; }
    public string ImageFilePath8 { get; set; }

    public byte[] Image9 { get; set; }
    public string ImageFilePath9 { get; set; }

    public byte[] Image10 { get; set; }
    public string ImageFilePath10 { get; set; }

    public int? UserId { get; set; }

  }

  public class ServiceRequestDTO
  {
    public int Id { get; set; }
    [Required]
    public int? SlurryWearType { get; set; }
    public int? Industry { get; set; }
    public int? Application { get; set; }
    public int? SlurryType { get; set; }
    public int? HeadDuties { get; set; }
    public int? PumpType { get; set; }
    public int? ComponentType { get; set; }
    public string PumpModel { get; set; }
    public string PumpSize { get; set; }
    public string DischargeOrientation { get; set; }
    public string Impeller { get; set; }
    public string DiameterRatio { get; set; }

    public int? PartLife { get; set; }
    public int? QBepPer { get; set; }
    public int? EfficiencyPer { get; set; }
    public string Solids { get; set; }
    public int? D50 { get; set; }
    public int? D85 { get; set; }
    public string ParticleShape { get; set; }
    public string Primary { get; set; }
    public string Secondary { get; set; }
    public string Suggestion { get; set; }
    public string RelatedWearPart { get; set; }
    public byte[] Image1 { get; set; }
    public string ImageFilePath1 { get; set; }
    public byte[] Image2 { get; set; }
    public string ImageFilePath2 { get; set; }
    public byte[] Image3 { get; set; }
    public string ImageFilePath3 { get; set; }
    public byte[] Image4 { get; set; }
    public string ImageFilePath4 { get; set; }
    public byte[] Image5 { get; set; }
    public string ImageFilePath5 { get; set; }

    public byte[] Image6 { get; set; }
    public string ImageFilePath6 { get; set; }

    public byte[] Image7 { get; set; }
    public string ImageFilePath7 { get; set; }

    public byte[] Image8 { get; set; }
    public string ImageFilePath8 { get; set; }

    public byte[] Image9 { get; set; }
    public string ImageFilePath9 { get; set; }

    public byte[] Image10 { get; set; }
    public string ImageFilePath10 { get; set; }

    public int? UserId { get; set; }

  }

  [Table("tblCaseStudySilver")]
  public class ServiceRequestSilver
  {
    public int Id { get; set; }
    [Required]
    public int? ComponentType { get; set; }
    public string MeasurementLocation1 { get; set; }
    public string MeasurementLocation2 { get; set; }
    public string MeasurementLocation3 { get; set; }
    public string MeasurementLocation4 { get; set; }
    public string MeasurementLocation5 { get; set; }
    public byte[] Image1 { get; set; }
    public string ImageFilePath1 { get; set; }
    public byte[] Image2 { get; set; }
    public string ImageFilePath2 { get; set; }
    public byte[] Image3 { get; set; }
    public string ImageFilePath3 { get; set; }
    public byte[] Image4 { get; set; }
    public string ImageFilePath4 { get; set; }
    public byte[] Image5 { get; set; }
    public string ImageFilePath5 { get; set; }

    public byte[] Image6 { get; set; }
    public string ImageFilePath6 { get; set; }

    public byte[] Image7 { get; set; }
    public string ImageFilePath7 { get; set; }

    public byte[] Image8 { get; set; }
    public string ImageFilePath8 { get; set; }

    public byte[] Image9 { get; set; }
    public string ImageFilePath9 { get; set; }

    public byte[] Image10 { get; set; }
    public string ImageFilePath10 { get; set; }

    public int? UserId { get; set; }

  }

  public class ServiceRequestSilverDTO
  {
    public int Id { get; set; }
    [Required]
    public int? ComponentType { get; set; }
    public string MeasurementLocation1 { get; set; }
    public string MeasurementLocation2 { get; set; }
    public string MeasurementLocation3 { get; set; }
    public string MeasurementLocation4 { get; set; }
    public string MeasurementLocation5 { get; set; }
    public byte[] Image1 { get; set; }
    public string ImageFilePath1 { get; set; }
    public byte[] Image2 { get; set; }
    public string ImageFilePath2 { get; set; }
    public byte[] Image3 { get; set; }
    public string ImageFilePath3 { get; set; }
    public byte[] Image4 { get; set; }
    public string ImageFilePath4 { get; set; }
    public byte[] Image5 { get; set; }
    public string ImageFilePath5 { get; set; }

    public byte[] Image6 { get; set; }
    public string ImageFilePath6 { get; set; }

    public byte[] Image7 { get; set; }
    public string ImageFilePath7 { get; set; }

    public byte[] Image8 { get; set; }
    public string ImageFilePath8 { get; set; }

    public byte[] Image9 { get; set; }
    public string ImageFilePath9 { get; set; }

    public byte[] Image10 { get; set; }
    public string ImageFilePath10 { get; set; }

    public int? UserId { get; set; }

  }

}