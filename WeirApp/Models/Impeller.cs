using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
    [Table("tblImpeller")]
    public class Impeller
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public int Year { get; set; }
        //public decimal Price { get; set; }
        //public string Genre { get; set; }

        //// Foreign Key
        //public int AuthorId { get; set; }
        //// Navigation property
        //public Lookup Author { get; set; }
    }

    public class ImpellerDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}