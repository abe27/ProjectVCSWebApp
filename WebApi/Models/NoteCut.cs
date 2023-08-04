using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("NOTECUT")]
    public class NoteCut
    {
        [Column("FCAPPNAME")]
        public string? fcappname { get; set; }

        [Column("FCBRANCH")]
        public string? fcbranch { get; set; }

        [Column("FCCHILDH")]
        public string? fcchildh { get; set; }

        [Column("FCCHILDI")]
        public string? fcchildi { get; set; }

        [Column("FCCHILDTYP")]
        public string? fcchildtyp { get; set; }

        [Column("FCCORP")]
        public string? fccorp { get; set; }

        [Column("FCCORRECTB")]
        public string? fccorrectb { get; set; }

        [Column("FCCREATEAP")]
        public string? fccreateap { get; set; }

        [Column("FCCREATEBY")]
        public string? fccreateby { get; set; }

        [Column("FCCREATETY")]
        public string? fccreatety { get; set; }

        [Column("FCCUACC")]
        public string? fccuacc { get; set; }

        [Column("FCDATAIMP")]
        public string? fcdataimp { get; set; }

        [Column("FCDATASER")]
        public string? fcdataser { get; set; }

        [Column("FCEAFTERR")]
        public string? fceafterr { get; set; }

        [Column("FCLUPDAPP")]
        public string? fclupdapp { get; set; }

        [Column("FCMASTERH")]
        public string? fcmasterh { get; set; }

        [Column("FCMASTERI")]
        public string? fcmasteri { get; set; }

        [Column("FCMASTERTY")]
        public string? fcmasterty { get; set; }

        [Column("FCORGCODE")]
        public string? fcorgcode { get; set; }

        [Column("FCSELTAG")]
        public string? fcseltag { get; set; }

        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        public string? fcskid { get; set; }

        [Column("FCSRCUPD")]
        public string? fcsrcupd { get; set; }

        [Column("FCU1ACC")]
        public string? fcu1acc { get; set; }

        [Column("FCUDATE")]
        public string? fcudate { get; set; }

        [Column("FCUTIME")]
        public string? fcutime { get; set; }

        [Column("FIMILLISEC")]
        public int? fimillisec { get; set; }

        [Column("FMEXTRATAG")]
        public string? fmextratag { get; set; }

        [Column("FNQTY")]
        public decimal? fnqty { get; set; }

        [Column("FNUMQTY")]
        public decimal? fnumqty { get; set; }

        [Column("FTDATETIME")]
        public DateTime? ftdatetime { get; set; }

        [Column("FTLASTEDIT")]
        public DateTime? ftlastedit { get; set; }

        [Column("FTLASTUPD")]
        public DateTime? ftlastupd { get; set; }

        [Column("FTSRCUPD")]
        public string? ftsrcupd { get; set; }

        // Corp       *Corp     `gorm:"foreignKey:FCCORP;references:FCSKID;" json:"corp"`
        [ForeignKey(nameof(fccorp))]
        public Corp? corp { get; set; }

        // Branch     *Branch   `gorm:"foreignKey:FCBRANCH;references:FCSKID;" json:"branch"`
        [ForeignKey(nameof(fcbranch))]
        public Branch? branch { get; set; }

        // Orderh     *Orderh   `gorm:"foreignKey:FCCHILDH;references:FCSKID;" json:"orderh"`
        [ForeignKey(nameof(fcchildh))]
        public OrderHead? orderh { get; set; }

        // Orderi     *Orderi   `gorm:"foreignKey:FCCHILDI;references:FCSKID;" json:"orderi"`
        [ForeignKey(nameof(fcchildi))]
        public OrderDetail? orderi { get; set; }

        // Glref      *Glref    `gorm:"foreignKey:FCMASTERH;references:FCSKID;" json:"glref"`
        [ForeignKey(nameof(fcmasterh))]
        public GlRef? glref { get; set; }

        // Refprod    *Refprod  `gorm:"foreignKey:FCMASTERI;references:FCSKID;" json:"refsprod"`
        [ForeignKey(nameof(fcmasteri))]
        public RefProd? refsprod { get; set; }
    }
}
