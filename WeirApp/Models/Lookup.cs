using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeirApp.Models
{
    [Table("tblLookup")]
    public class Lookup
    {
        public int Id { get; set; }
        [Required]
        public string LookupValue { get; set; }
        public string LookupType { get; set; }

        public bool Active { get; set; }

        public int? Sequence { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        public int? ParentLookup { get; set; }
    }

    public class LookupDTO
    {
        public int Id { get; set; }
        [Required]
        public string LookupValue { get; set; }
        public string LookupType { get; set; }
        public bool Active { get; set; }
        public int? Sequence { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public DateTime? UpdatedDateTime { get; set; }

        public int? ParentLookup { get; set; }
    }
}