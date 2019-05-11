using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
    [Table("tblMeasurement")]
    public class Measurement
    {
        public int Id { get; set; }
        [Required]
        public string MeasurementLocation1 { get; set; }
        public string MeasurementLocation2 { get; set; }
        public string MeasurementLocation3 { get; set; }
        public string MeasurementLocation4 { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedTime { get; set; }
        public int? UserId { get; set; }
    }

    public class MeasurementDTO
    {
        public int Id { get; set; }
        [Required]
        public string MeasurementLocation1 { get; set; }
        public string MeasurementLocation2 { get; set; }
        public string MeasurementLocation3 { get; set; }
        public string MeasurementLocation4 { get; set; }
        public string UpdatedDate { get; set; }
        public string UpdatedTime { get; set; }
        public int? UserId { get; set; }
    }
}