using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("ACCBOOK")]
public class AccountingBook
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Column("FCSKID")]
    public string? fcskid { get; set; }

    [Column("FCCODE")]
    public string? fccode { get; set; }

    [Column("FCNAME")]
    public string? fcname { get; set; }

    [Column("FCCORP")]
    public string? fccorp { get; set; }

    [Column("FCNAME2")]
    public string? fcname2 { get; set; }
}
