using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("PDGRP")]
    public class PdGroup
    {
        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        public string? fcskid { get; set; }

        [Column("FCCORP")]
        public string? fccorp { get; set; }

        [Column("FCCODE")]
        public string? fccode { get; set; }

        [Column("FCNAME")]
        public string? fcname { get; set; }

        [Column("FCTYPE")]
        public string? fctype { get; set; }

        [ForeignKey(nameof(fccorp))]
        public Corp? corp { get; set; }
    }
}
