using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace WebApi.Models
{
    [Table("ORDERI")]
    public class OrderDetail
    {
        [Column("FCACCHART")]
        public string? fcacchart { get; set; }//str

        [Column("FCAPPNAME")]
        public string? fcappname { get; set; }//str

        [Column("FCAPPROVEB")]
        public string? fcapproveb { get; set; }//str

        [Column("FCBOICARD")]
        public string? fcboicard { get; set; }//str

        [Column("FCBOIGROUP")]
        public string? fcboigroup { get; set; }//str

        [Column("FCBRANCH")]
        public string? fcbranch { get; set; }//str

        [Column("FCBUDCHART")]
        public string? fcbudchart { get; set; }//str

        [Column("FCCOOR")]
        public string? fccoor { get; set; }//str

        [Column("FCCORP")]
        public string? fccorp { get; set; }//str

        [Column("FCCORRECTB")]
        public string? fccorrectb { get; set; }//str

        [Column("FCCOUNTER")]
        public string? fccounter { get; set; }//str

        [Column("FCCREATEAP")]
        public string? fccreateap { get; set; }//str

        [Column("FCCREATEBY")]
        public string? fccreateby { get; set; }//str

        [Column("FCCREATETY")]
        public string? fccreatety { get; set; }//str

        [Column("FCCTRLSTOC")]
        public string? fcctrlstoc { get; set; }//str

        [Column("FCCUACC")]
        public string? fccuacc { get; set; }//str

        [Column("FCDATAIMP")]
        public string? fcdataimp { get; set; }//str

        [Column("FCDATASER")]
        public string? fcdataser { get; set; }//str

        [Column("FCDELITIME")]
        public string? fcdelitime { get; set; }//str

        [Column("FCDEPT")]
        public string? fcdept { get; set; }//str

        [Column("FCDISCSTR")]
        public string? fcdiscstr { get; set; }//str

        [Column("FCDTYPE1")]
        public string? fcdtype1 { get; set; }//str

        [Column("FCDTYPE2")]
        public string? fcdtype2 { get; set; }//str

        [Column("FCEAFTERR")]
        public string? fceafterr { get; set; }//str

        [Column("FCFORMULAS")]
        public string? fcformulas { get; set; }//str

        [Column("FCGAG")]
        public string? fcgag { get; set; }//str

        [Column("FCGVPOLICY")]
        public string? fcgvpolicy { get; set; }//str

        [Column("FCIOTYPE")]
        public string? fciotype { get; set; }//str

        [Column("FCISCHG")]
        public string? fcischg { get; set; }//str

        [Column("FCJOB")]
        public string? fcjob { get; set; }//str

        [Column("FCLID")]
        public string? fclid { get; set; }//str

        [Column("FCLOT")]
        public string? fclot { get; set; }//str

        [Column("FCLUPDAPP")]
        public string? fclupdapp { get; set; }//str

        [Column("FCMAINJOBH")]
        public string? fcmainjobh { get; set; }//str

        [Column("FCMSTEP")]
        public string? fcmstep { get; set; }//str

        [Column("FCORDERH")]
        public string? fcorderh { get; set; }//str

        [Column("FCORGCODE")]
        public string? fcorgcode { get; set; }//str

        [Column("FCPDSTHPAC")]
        public string? fcpdsthpac { get; set; }//str

        [Column("FCPFORMULA")]
        public string? fcpformula { get; set; }//str

        [Column("FCPLANT")]
        public string? fcplant { get; set; }//str

        [Column("FCPRICE")]
        public string? fcprice { get; set; }//str

        [Column("FCPRICEBY")]
        public string? fcpriceby { get; set; }//str

        [Column("FCPRIORITY")]
        public string? fcpriority { get; set; }//str

        [Column("FCPROCHAIN")]
        public string? fcprochain { get; set; }//str

        [Column("FCPROD")]
        public string? fcprod { get; set; }//str

        [Column("FCPRODTYPE")]
        public string? fcprodtype { get; set; }//str

        [Column("FCPROJ")]
        public string? fcproj { get; set; }//str

        [Column("FCRECALBY")]
        public string? fcrecalby { get; set; }//str

        [Column("FCREFPDTYP")]
        public string? fcrefpdtyp { get; set; }//str

        [Column("FCREFTYPE")]
        public string? fcreftype { get; set; }//str

        [Column("FCREMLOCAT")]
        public string? fcremlocat { get; set; }//str

        [Column("FCROOTSEQ")]
        public string? fcrootseq { get; set; }//str

        [Column("FCSECT")]
        public string? fcsect { get; set; }//str

        [Column("FCSELTAG")]
        public string? fcseltag { get; set; }//str

        [Column("FCSEQ")]
        public string? fcseq { get; set; }//str

        [Column("FCSHOWCOMP")]
        public string? fcshowcomp { get; set; }//str

        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        public string? fcskid { get; set; }//str

        [Column("FCSRCUPD")]
        public string? fcsrcupd { get; set; }//str

        [Column("FCSTAT")]
        public string? fcstat { get; set; }//str

        [Column("FCSTEP")]
        public string? fcstep { get; set; }//str

        [Column("FCSTEP2")]
        public string? fcstep2 { get; set; }//str

        [Column("FCSTORE")]
        public string? fcstore { get; set; }//str

        [Column("FCSTUM")]
        public string? fcstum { get; set; }//str

        [Column("FCSTUMSTD")]
        public string? fcstumstd { get; set; }//str

        [Column("FCSUBBR")]
        public string? fcsubbr { get; set; }//str

        [Column("FCSUBJOBH")]
        public string? fcsubjobh { get; set; }//str

        [Column("FCSUBTXID")]
        public string? fcsubtxid { get; set; }//str

        [Column("FCTXID")]
        public string? fctxid { get; set; }//str

        [Column("FCTXIDLINK")]
        public string? fctxidlink { get; set; }//str

        [Column("FCU1ACC")]
        public string? fcu1acc { get; set; }//str

        [Column("FCU1STATUS")]
        public string? fcu1status { get; set; }//str

        [Column("FCU2STATUS")]
        public string? fcu2status { get; set; }//str

        [Column("FCUDATE")]
        public string? fcudate { get; set; }//str

        [Column("FCUM")]
        public string? fcum { get; set; }//str

        [Column("FCUMSTD")]
        public string? fcumstd { get; set; }//str

        [Column("FCUTIME")]
        public string? fcutime { get; set; }//str

        [Column("FCVATISOUT")]
        public string? fcvatisout { get; set; }//str

        [Column("FCVATTYPE")]
        public string? fcvattype { get; set; }//str

        [Column("FCWHOUSE")]
        public string? fcwhouse { get; set; }//str

        [Column("FDAPPROVE")]
        public DateTime? fdapprove { get; set; }//tim

        [Column("FDDATE")]
        public DateTime? fddate { get; set; }//tim

        [Column("FDDELIVERY")]
        public DateTime? fddelivery { get; set; }//tim

        [Column("FDEXPIRE")]
        public string? fdexpire { get; set; }//str

        [Column("FDMFGDATE")]
        public string? fdmfgdate { get; set; }//str

        [Column("FIMILLISEC")]
        public int? fimillisec { get; set; }//int

        [Column("FMERRMSG")]
        public string? fmerrmsg { get; set; }//str

        [Column("FMEXTRATAG")]
        public string? fmextratag { get; set; }//str

        [Column("FMREMARK")]
        public string? fmremark { get; set; }//str

        [Column("FMREMARK10")]
        public string? fmremark10 { get; set; }//str

        [Column("FMREMARK2")]
        public string? fmremark2 { get; set; }//str

        [Column("FMREMARK3")]
        public string? fmremark3 { get; set; }//str

        [Column("FMREMARK4")]
        public string? fmremark4 { get; set; }//str

        [Column("FMREMARK5")]
        public string? fmremark5 { get; set; }//str

        [Column("FMREMARK6")]
        public string? fmremark6 { get; set; }//str

        [Column("FMREMARK7")]
        public string? fmremark7 { get; set; }//str

        [Column("FMREMARK8")]
        public string? fmremark8 { get; set; }//str

        [Column("FMREMARK9")]
        public string? fmremark9 { get; set; }//str

        [Column("FMTEXTKE")]
        public string? fmtextke { get; set; }//str

        [Column("FNBACKQTY")]
        public decimal? fnbackqty { get; set; }//flo

        [Column("FNDEFAPRIC")]
        public decimal? fndefapric { get; set; }//flo

        [Column("FNDISCAMT")]
        public decimal? fndiscamt { get; set; }//flo

        [Column("FNDISCAMTK")]
        public decimal? fndiscamtk { get; set; }//flo

        [Column("FNDISCPCN")]
        public decimal? fndiscpcn { get; set; }//flo

        [Column("FNDOQTY")]
        public decimal? fndoqty { get; set; }//flo

        [Column("FNPACKQTY")]
        public decimal? fnpackqty { get; set; }//flo

        [Column("FNPLANQTY")]
        public decimal? fnplanqty { get; set; }//flo

        [Column("FNPRICE")]
        public decimal? fnprice { get; set; }//flo

        [Column("FNPRICEKE")]
        public decimal? fnpriceke { get; set; }//flo

        [Column("FNPRQTY")]
        public decimal? fnprqty { get; set; }//flo

        [Column("FNQTY  ")]
        public decimal? fnqty { get; set; }//flo

        [Column("FNSTQTY")]
        public decimal? fnstqty { get; set; }//flo

        [Column("FNSTUMQTY")]
        public decimal? fnstumqty { get; set; }//flo

        [Column("FNU1CNT")]
        public decimal? fnu1cnt { get; set; }//flo

        [Column("FNU2CNT")]
        public decimal? fnu2cnt { get; set; }//flo

        [Column("FNUMQTY")]
        public decimal? fnumqty { get; set; }//flo

        [Column("FNVATAMT")]
        public decimal? fnvatamt { get; set; }//flo

        [Column("FNVATRATE")]
        public decimal? fnvatrate { get; set; }//flo

        [Column("FNWTAXAMT")]
        public decimal? fnwtaxamt { get; set; }//flo

        [Column("FNWTAXAMTK")]
        public decimal? fnwtaxamtk { get; set; }//flo

        [Column("FNWTAXRATE")]
        public decimal? fnwtaxrate { get; set; }//flo

        [Column("FNXRATE")]
        public decimal? fnxrate { get; set; }//flo

        [Column("FTDATETIME")]
        public DateTime? ftdatetime { get; set; }//tim

        [Column("FTLASRECAL")]
        public string? ftlasrecal { get; set; }//str

        [Column("FTLASTEDIT")]
        public DateTime? ftlastedit { get; set; }//tim

        [Column("FTLASTUPD")]
        public DateTime? ftlastupd { get; set; }//tim

        [Column("FTSRCUPD")]
        public string? ftsrcupd { get; set; }//str

        // Corp       *Corp      `gorm:"foreignKey:FCCORP;references:FCSKID;" json:"corp"`
        [ForeignKey(nameof(fccorp))]
        public Corp? corp { get; set; }

        // Branch     *Branch    `gorm:"foreignKey:FCBRANCH;references:FCSKID;" json:"branch"`
        [ForeignKey(nameof(fcbranch))]
        public Branch? branch { get; set; }

        // Dept       *Dept      `gorm:"foreignKey:FCDEPT;references:FCSKID;" json:"department"`
        [ForeignKey(nameof(fcdept))]
        public Department? department { get; set; }

        // Sect       *Sect      `gorm:"foreignKey:FCSECT;references:FCSKID;" json:"section"`
        [ForeignKey(nameof(fcsect))]
        public Sect? section { get; set; }

        // Job        *Job       `gorm:"foreignKey:FCJOB;references:FCSKID;" json:"job"`
        [ForeignKey(nameof(fcjob))]
        public Job? job { get; set; }

        // Orderh     *Orderh    `gorm:"foreignKey:FCORDERH;references:FCSKID;" json:"order_head"`
        [ForeignKey(nameof(fcorderh))]
        public OrderHead? order_head { get; set; }

        // Coor       *Coor      `gorm:"foreignKey:FCCOOR;references:FCSKID;" json:"coor"`
        [ForeignKey(nameof(fccoor))]
        public Coor? coor { get; set; }

        // Product    *Product `gorm:"foreignKey:FCPROD;references:FCSKID;" json:"product"`
        [ForeignKey(nameof(fcprod))]
        public Product? product { get; set; }

        // Unit       *Unit      `gorm:"foreignKey:FCUM;references:FCSKID;" json:"unit"`
        [ForeignKey(nameof(fcum))]
        public Unit? unit { get; set; }

        // UnitSTD    *Unit      `gorm:"foreignKey:FCUMSTD;references:FCSKID;" json:"unit_standard"`
        [ForeignKey(nameof(fcumstd))]
        public Unit? unit_standard { get; set; }

        // WHouse     *WHouse    `gorm:"foreignKey:FCWHOUSE;references:FCSKID;" json:"whouse"`
        [ForeignKey(nameof(fcwhouse))]
        public Whs? whouse { get; set; }

        // Proj       *Proj      `gorm:"foreignKey:FCPROJ;references:FCSKID;" json:"proj"`
        [ForeignKey(nameof(fcproj))]
        public Project? proj { get; set; }

        // Stum       *Unit      `gorm:"foreignKey:FCSTUM;references:FCSK;" json:"stum"`
        [ForeignKey(nameof(fcstum))]
        public Unit? stum { get; set; }

        // StumStd    *Unit      `gorm:"foreignKey:FCSTUMSTD;references:FCSK;" json:"stum_std"`
        [ForeignKey(nameof(fcstumstd))]
        public Unit? stum_std { get; set; }

        // CreatedBy  *Empl      `gorm:"foreignKey:FCCREATEBY;references:FCSKID;" json:"created_by"`
        [ForeignKey(nameof(fccreateby))]
        public Employee? created_by { get; set; }
    }
}
