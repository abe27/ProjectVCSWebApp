using NanoidDotNet;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    [Table("DEPT")]
    public class Department
    {
        [Key, Column("FCSKID"), StringLength(8)]
        public string fcskid { get; set; } = Nanoid.Generate(size: 8);

        [Column("FCCODE")]
        public string? fccode { get; set; }

        [Column("FCNAME")]
        public string? fcname { get; set; }
    }

    [Table("SECT")]
    public class Sect
    {
        [Key, Column("FCSKID"), StringLength(8)]
        public string fcskid { get; set; } = Nanoid.Generate(size: 8);

        [Column("FCCODE")]
        public string? fccode { get; set; }

        [Column("FCCORP")]
        public string? fccorp { get; set; }

        [Column("FCDEPT")]
        public string? fcdept { get; set; }

        [Column("FCNAME")]
        public string? fcname { get; set; }

        [Column("FCNAME2")]
        public string? fcname2 { get; set; }

        [ForeignKey(nameof(fccorp))]
        public Corp? corp { get; set; }

        [ForeignKey(nameof(fcdept))]
        public Department? dept { get; set; }
    }
}
