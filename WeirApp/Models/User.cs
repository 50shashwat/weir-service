using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
    [Table("tblUser")]
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }

        public string Password { get; set; }
        public int UserType { get; set; }
    }

    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }

        public string Password { get; set; }

        public string NewPassword { get; set; }
        public string Token { get; set; }
        public int UserType { get; set; }
    }
}