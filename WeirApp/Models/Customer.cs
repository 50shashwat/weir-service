using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
    [Table("tblCustomer")]
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class CustomerDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}