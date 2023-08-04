using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("STOCK")]
    public class Stock
    {
        [Column("FCDATASER")]
        public string? fcdataser { get; set; }//str

        [Column("FCUDATE")]
        public string? fcudate { get; set; }//str

        [Column("FCUTIME")]
        public string? fcutime { get; set; }//str

        [Column("FCLUPDAPP")]
        public string? fclupdapp { get; set; }//str

        [Column("FCBAKYRHIS")]
        public string? fcbakyrhis { get; set; }//str

        [Column("FCCORP")]
        public string? fccorp { get; set; }//str

        [Column("FCBRANCH")]
        public string? fcbranch { get; set; }//str

        [Column("FCWHOUSE")]
        public string? fcwhouse { get; set; }//str

        [Column("FCPROD")]
        public string? fcprod { get; set; }//str

        [Column("FCLOT")]
        public string? fclot { get; set; }//str

        [Column("FDDATE")]
        public DateTime? fddate { get; set; }//tim

        [Column("FNAVGCOST")]
        public decimal? fnavgcost { get; set; }//flo

        [Column("FNQTY")]
        public decimal? fnqty { get; set; }//flo

        [Column("FNSTQTYSTD")]
        public decimal? fnstqtystd { get; set; }//flo

        [Column("FNPRICE")]
        public decimal? fnprice { get; set; }//flo

        [Column("FNEDPRICE")]
        public decimal? fnedprice { get; set; }//flo

        [Column("FNCOST")]
        public decimal? fncost { get; set; }//flo

        [Column("FCCREATETY")]
        public string? fccreatety { get; set; }//str

        [Column("FCEAFTERR")]
        public string? fceafterr { get; set; }//str

        [Column("FCSELTAG")]
        public string? fcseltag { get; set; }//str

        [Column("FTDATETIME")]
        public DateTime? ftdatetime { get; set; }//tim

        [Column("FIMILLISEC")]
        public int? fimillisec { get; set; }//int

        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        public string? fcskid { get; set; }//str

        [Column("FNUNQCQTY")]
        public decimal? fnunqcqty { get; set; }//flo

        [Column("FNUNDOQTY")]
        public decimal? fnundoqty { get; set; }//flo

        [Column("FNSOALLOCQ")]
        public decimal? fnsoallocq { get; set; }//flo

        [Column("FCGAG")]
        public string? fcgag { get; set; }//str

        [Column("FDMFGDATE")]
        public string? fdmfgdate { get; set; }//str

        [Column("FDEXPIRE")]
        public string? fdexpire { get; set; }//str

        [Column("FNDOQTY")]
        public decimal? fndoqty { get; set; }//flo

        [Column("FNGRNQTY")]
        public decimal? fngrnqty { get; set; }//flo

        [Column("FTLASTUPD")]
        public DateTime? ftlastupd { get; set; }//tim

        [Column("FTLASTEDIT")]
        public DateTime? ftlastedit { get; set; }//tim

        [Column("FNALLOCQTY")]
        public decimal? fnallocqty { get; set; }//flo

        [Column("FCCREATEAP")]
        public string? fccreateap { get; set; }//str

        [Column("FCU1ACC")]
        public string? fcu1acc { get; set; }//str

        [Column("FCDATAIMP")]
        public string? fcdataimp { get; set; }//str

        [Column("FCMANFLAG")]
        public string? fcmanflag { get; set; }//str

        [Column("FCADDAPVBY")]
        public string? fcaddapvby { get; set; }//str

        [Column("FCEDTAPVBY")]
        public string? fcedtapvby { get; set; }//str

        [Column("FCDELAPVBY")]
        public string? fcdelapvby { get; set; }//str

        [Column("FCISUSED")]
        public string? fcisused { get; set; }//str

        [Column("FDRECDATE")]
        public string? fdrecdate { get; set; }//str

        [Column("FCLOCATION")]
        public string? fclocation { get; set; }//str

        [Column("FCSTORE")]
        public string? fcstore { get; set; }//str

        [Column("FCLID")]
        public string? fclid { get; set; }//str

        [Column("FCCREATEBY")]
        public string? fccreateby { get; set; }//str

        [Column("FCCORRECTB")]
        public string? fccorrectb { get; set; }//str

        [Column("FCU1STATUS")]
        public string? fcu1status { get; set; }//str

        [Column("FCDTYPE1")]
        public string? fcdtype1 { get; set; }//str

        [Column("FNU1CNT")]
        public decimal? fnu1cnt { get; set; }//flo

        [Column("FCU2STATUS")]
        public string? fcu2status { get; set; }//str

        [Column("FCDTYPE2")]
        public string? fcdtype2 { get; set; }//str

        [Column("FNU2CNT")]
        public decimal? fnu2cnt { get; set; }//flo

        [Column("FCU3STATUS")]
        public string? fcu3status { get; set; }//str

        [Column("FCDTYPE3")]
        public string? fcdtype3 { get; set; }//str

        [Column("FNU3CNT")]
        public decimal? fnu3cnt { get; set; }//flo

        [Column("FCU4STATUS")]
        public string? fcu4status { get; set; }//str

        [Column("FCDTYPE4")]
        public string? fcdtype4 { get; set; }//str

        [Column("FNU4CNT")]
        public decimal? fnu4cnt { get; set; }//flo

        [Column("FCU5STATUS")]
        public string? fcu5status { get; set; }//str

        [Column("FCDTYPE5")]
        public string? fcdtype5 { get; set; }//str

        [Column("FNU5CNT")]
        public decimal? fnu5cnt { get; set; }//flo

        [Column("FCU6STATUS")]
        public string? fcu6status { get; set; }//str

        [Column("FCDTYPE6")]
        public string? fcdtype6 { get; set; }//str

        [Column("FNU6CNT")]
        public decimal? fnu6cnt { get; set; }//flo

        [Column("FCU7STATUS")]
        public string? fcu7status { get; set; }//str

        [Column("FCDTYPE7")]
        public string? fcdtype7 { get; set; }//str

        [Column("FNU7CNT")]
        public decimal? fnu7cnt { get; set; }//flo

        [Column("FCU8STATUS")]
        public string? fcu8status { get; set; }//str

        [Column("FCDTYPE8")]
        public string? fcdtype8 { get; set; }//str

        [Column("FNU8CNT")]
        public decimal? fnu8cnt { get; set; }//flo

        [Column("FCU9STATUS")]
        public string? fcu9status { get; set; }//str

        [Column("FCDTYPE9")]
        public string? fcdtype9 { get; set; }//str

        [Column("FNU9CNT")]
        public decimal? fnu9cnt { get; set; }//flo

        [Column("FCGID")]
        public string? fcgid { get; set; }//str

        [Column("FTSRCUPD")]
        public string? ftsrcupd { get; set; }//str

        [Column("FCSRCUPD")]
        public string? fcsrcupd { get; set; }//str

        [Column("FMEXTRATAG")]
        public string? fmextratag { get; set; }//str

        [Column("FCORGCODE")]
        public string? fcorgcode { get; set; }//str

        [Column("FCCUACC")]
        public string? fccuacc { get; set; }//str

        [Column("FCAPPNAME")]
        public string? fcappname { get; set; }//str

        [ForeignKey(nameof(fcprod))]
        public Product? product { get; set; }

        [ForeignKey(nameof(fcwhouse))]
        public Whs? whouse { get; set; }
    }
}
