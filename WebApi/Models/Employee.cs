using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using NanoidDotNet;

namespace WebApi.Models
{
    [Table("EMPLR")]
    public class Employee
    {
        [Key]
        [StringLength(8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("FCSKID")]
        public string skid { get; set; } = Nanoid.Generate(size: 8);

        [Required]
        [StringLength(50)]
        [Column("FCLOGIN")]
        public required string username { get; set; }

        [Required]
        [StringLength(50)]
        [Column("FCPW")]
        public required string password { get; set; }

        [Column("FIMILLISEC")]
        public int millisec { get; set; } = DateTime.Now.Millisecond;

        [Column("FTDATETIME")]
        public DateTime? datetime { get; set; } = DateTime.Now;

        [Column("FTLASTUPD")]
        public DateTime? lastupdate { get; set; } = DateTime.Now;

        [Column("FTLASTEDIT")]
        public DateTime? lastedit { get; set; } = DateTime.Now;

        [Column("FDLSTCHGPA")]
        public DateTime? lstchgpa { get; set; } = DateTime.Now;

        [Column("FDLSTLOGIN")]
        public DateTime? lstlogin { get; set; } = DateTime.Now;
    }

    public class FrmEmployee
    {
        [Required]
        [StringLength(50)]
        public required string username { get; set; }

        [Required]
        [StringLength(50)]
        public required string password { get; set; }
    }
}
