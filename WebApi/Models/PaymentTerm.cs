using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("PAYTERM")]
    public class PaymentTerm
    {
        [Column("FCDATASER ")]
        public string? fcdataser { get; set; }//str

        [Key]
        [StringLength(8)]
        [Column("FCSKID ")]
        public string? fcskid { get; set; }//str

        [Column("FCUDATE ")]
        public string? fcudate { get; set; }//str

        [Column("FCUTIME ")]
        public string? fcutime { get; set; }//str

        [Column("FCLUPDAPP ")]
        public string? fclupdapp { get; set; }//str

        [Column("FCBAKYRHIS ")]
        public string? fcbakyrhis { get; set; }//str

        [Column("FCCORP ")]
        public string? fccorp { get; set; }//str

        [Column("FCCODE ")]
        public string? fccode { get; set; }//str

        [Column("FCNAME ")]
        public string? fcname { get; set; }//str

        [Column("FCFCHR ")]
        public string? fcfchr { get; set; }//str

        [Column("FCNAME2 ")]
        public string? fcname2 { get; set; }//str

        [Column("FCCREATETY ")]
        public string? fccreatety { get; set; }//str

        [Column("FCEAFTERR ")]
        public string? fceafterr { get; set; }//str

        [Column("FCSELTAG ")]
        public string? fcseltag { get; set; }//str

        [Column("FTDATETIME ")]
        public string? ftdatetime { get; set; }//str

        [Column("FIMILLISEC ")]
        public string? fimillisec { get; set; }//str

        [Column("FTLASTUPD ")]
        public string? ftlastupd { get; set; }//str

        [Column("FTLASTEDIT ")]
        public DateTime? ftlastedit { get; set; }//tim

        [Column("FCCREATEAP ")]
        public string? fccreateap { get; set; }//str

        [Column("FCU1ACC ")]
        public string? fcu1acc { get; set; }//str

        [Column("FCDATAIMP ")]
        public string? fcdataimp { get; set; }//str

        [Column("FCCREATEBY ")]
        public string? fccreateby { get; set; }//str

        [Column("FCCORRECTB ")]
        public string? fccorrectb { get; set; }//str

        [Column("FCLID ")]
        public string? fclid { get; set; }//str

        [Column("FCU1STATUS ")]
        public string? fcu1status { get; set; }//str

        [Column("FCDTYPE1 ")]
        public string? fcdtype1 { get; set; }//str

        [Column("FNU1CNT ")]
        public string? fnu1cnt { get; set; }//str

        [Column("FCU2STATUS ")]
        public string? fcu2status { get; set; }//str

        [Column("FCDTYPE2 ")]
        public string? fcdtype2 { get; set; }//str

        [Column("FNU2CNT ")]
        public string? fnu2cnt { get; set; }//str

        [Column("FCU3STATUS ")]
        public string? fcu3status { get; set; }//str

        [Column("FCDTYPE3 ")]
        public string? fcdtype3 { get; set; }//str

        [Column("FNU3CNT ")]
        public string? fnu3cnt { get; set; }//str

        [Column("FCU4STATUS ")]
        public string? fcu4status { get; set; }//str

        [Column("FCDTYPE4 ")]
        public string? fcdtype4 { get; set; }//str

        [Column("FNU4CNT ")]
        public string? fnu4cnt { get; set; }//str

        [Column("FCU5STATUS ")]
        public string? fcu5status { get; set; }//str

        [Column("FCDTYPE5 ")]
        public string? fcdtype5 { get; set; }//str

        [Column("FNU5CNT ")]
        public string? fnu5cnt { get; set; }//str

        [Column("FCU6STATUS ")]
        public string? fcu6status { get; set; }//str

        [Column("FCDTYPE6 ")]
        public string? fcdtype6 { get; set; }//str

        [Column("FNU6CNT ")]
        public string? fnu6cnt { get; set; }//str

        [Column("FCU7STATUS ")]
        public string? fcu7status { get; set; }//str

        [Column("FCDTYPE7 ")]
        public string? fcdtype7 { get; set; }//str

        [Column("FNU7CNT ")]
        public string? fnu7cnt { get; set; }//str

        [Column("FCU8STATUS ")]
        public string? fcu8status { get; set; }//str

        [Column("FCDTYPE8 ")]
        public string? fcdtype8 { get; set; }//str

        [Column("FNU8CNT ")]
        public string? fnu8cnt { get; set; }//str

        [Column("FCU9STATUS ")]
        public string? fcu9status { get; set; }//str

        [Column("FCDTYPE9 ")]
        public string? fcdtype9 { get; set; }//str

        [Column("FNU9CNT ")]
        public string? fnu9cnt { get; set; }//str

        [Column("FCGID ")]
        public string? fcgid { get; set; }//str

        [Column("FTSRCUPD ")]
        public string? ftsrcupd { get; set; }//str

        [Column("FCSRCUPD ")]
        public string? fcsrcupd { get; set; }//str

        [Column("FMEXTRATAG ")]
        public string? fmextratag { get; set; }//str

        [Column("FCORGCODE ")]
        public string? fcorgcode { get; set; }//str

        [Column("FCCUACC ")]
        public string? fccuacc { get; set; }//str

        [Column("FCAPPNAME ")]
        public string? fcappname { get; set; }//str

        [ForeignKey(nameof(fccorp))]
        public Corp? corp { get; set; }
    }
}
