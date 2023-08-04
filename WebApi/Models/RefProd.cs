using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace WebApi.Models
{
    [Table("REFPROD")]
    public class RefProd
    {
        [Column("FCACCHART")]
        public string? fcacchart { get; set; }//str

        [Column("FCAPPNAME")]
        public string? fcappname { get; set; }//str

        [Column("FCBOICARD")]
        public string? fcboicard { get; set; }//str

        [Column("FCBOIGROUP")]
        public string? fcboigroup { get; set; }//str

        [Column("FCBRANCH")]
        public string? fcbranch { get; set; }//str

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

        [Column("FCCUACC")]
        public string? fccuacc { get; set; }//str

        [Column("FCDATAIMP")]
        public string? fcdataimp { get; set; }//str

        [Column("FCDATASER")]
        public string? fcdataser { get; set; }//str

        [Column("FCDEPT")]
        public string? fcdept { get; set; }//str

        [Column("FCDISCSTR")]
        public string? fcdiscstr { get; set; }//str

        [Column("FCEAFTERR")]
        public string? fceafterr { get; set; }//str

        [Column("FCFORMULAS")]
        public string? fcformulas { get; set; }//str

        [Column("FCGAG")]
        public string? fcgag { get; set; }//str

        [Column("FCGL")]
        public string? fcgl { get; set; }//str

        [Column("FCGLHEAD")]
        public string? fcglhead { get; set; }//str

        [Column("FCGLREF")]
        public string? fcglref { get; set; }//str

        [Column("FCGVPOLICY")]
        public string? fcgvpolicy { get; set; }//str

        [Column("FCIOTYPE")]
        public string? fciotype { get; set; }//str

        [Column("FCJOB")]
        public string? fcjob { get; set; }//str

        [Column("FCLAYSTEP")]
        public string? fclaystep { get; set; }//str

        [Column("FCLID")]
        public string? fclid { get; set; }//str

        [Column("FCLOCATION")]
        public string? fclocation { get; set; }//str

        [Column("FCLOT")]
        public string? fclot { get; set; }//str

        [Column("FCLUPDAPP")]
        public string? fclupdapp { get; set; }//str

        [Column("FCMAINJOBH")]
        public string? fcmainjobh { get; set; }//str

        [Column("FCMFGRUNB")]
        public string? fcmfgrunb { get; set; }//str

        [Column("FCMFGRUNE")]
        public string? fcmfgrune { get; set; }//str

        [Column("FCMNMGL")]
        public string? fcmnmgl { get; set; }//str

        [Column("FCMNMGLH")]
        public string? fcmnmglh { get; set; }//str

        [Column("FCMORDERH")]
        public string? fcmorderh { get; set; }//str

        [Column("FCMORDERI")]
        public string? fcmorderi { get; set; }//str

        [Column("FCORGCODE")]
        public string? fcorgcode { get; set; }//str

        [Column("FCPFORMULA")]
        public string? fcpformula { get; set; }//str

        [Column("FCPLANT")]
        public string? fcplant { get; set; }//str

        [Column("FCPRICEBY")]
        public string? fcpriceby { get; set; }//str

        [Column("FCPROCHAIN")]
        public string? fcprochain { get; set; }//str

        [Column("FCPROD")]
        public string? fcprod { get; set; }//str

        [Column("FCPRODTYPE")]
        public string? fcprodtype { get; set; }//str

        [Column("FCPROJ")]
        public string? fcproj { get; set; }//str

        [Column("FCPROMOTE")]
        public string? fcpromote { get; set; }//str

        [Column("FCQCPASS")]
        public string? fcqcpass { get; set; }//str

        [Column("FCRECALBY")]
        public string? fcrecalby { get; set; }//str

        [Column("FCRECOSTTY")]
        public string? fcrecostty { get; set; }//str

        [Column("FCREFDO")]
        public string? fcrefdo { get; set; }//str

        [Column("FCREFPDTYP")]
        public string? fcrefpdtyp { get; set; }//str

        [Column("FCREFTYPE")]
        public string? fcreftype { get; set; }//str

        [Column("FCREMLOCAT")]
        public string? fcremlocat { get; set; }//str

        [Column("FCRFTYPE")]
        public string? fcrftype { get; set; }//str

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

        [Column("FCSTEPD")]
        public string? fcstepd { get; set; }//str

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

        [Column("FCTIMESTAM")]
        public string? fctimestam { get; set; }//str

        [Column("FCTRANWHY")]
        public string? fctranwhy { get; set; }//str

        [Column("FCTXID")]
        public string? fctxid { get; set; }//str

        [Column("FCTXNO")]
        public string? fctxno { get; set; }//str

        [Column("FCU1ACC")]
        public string? fcu1acc { get; set; }//str

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

        [Column("FCXFERSTEP")]
        public string? fcxferstep { get; set; }//str

        [Column("FDDATE")]
        public DateTime? fddate { get; set; }//tim

        [Column("FDDELIVERY")]
        public string? fddelivery { get; set; }//str

        [Column("FDEXPIRE")]
        public string? fdexpire { get; set; }//str

        [Column("FDMFGDATE")]
        public string? fdmfgdate { get; set; }//str

        [Column("FIMILLISEC")]
        public int? fimillisec { get; set; }//int

        [Column("FMEXTRATAG")]
        public string? fmextratag { get; set; }//str

        [Column("FMMEMDATA")]
        public string? fmmemdata { get; set; }//str

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

        [Column("FNCOMMISSI")]
        public decimal? fncommissi { get; set; }//flo

        [Column("FNCOST")]
        public decimal? fncost { get; set; }//flo

        [Column("FNCOSTADJ")]
        public decimal? fncostadj { get; set; }//flo

        [Column("FNCOSTAMT")]
        public decimal? fncostamt { get; set; }//flo

        [Column("FNCOSTAVG")]
        public decimal? fncostavg { get; set; }//flo

        [Column("FNCOSTFIFO")]
        public decimal? fncostfifo { get; set; }//flo

        [Column("FNCOSTLOT")]
        public decimal? fncostlot { get; set; }//flo

        [Column("FNCOSTSTD")]
        public decimal? fncoststd { get; set; }//flo

        [Column("FNDEFAPRIC")]
        public decimal? fndefapric { get; set; }//flo

        [Column("FNDISCAMT")]
        public decimal? fndiscamt { get; set; }//flo

        [Column("FNDISCAMTK")]
        public decimal? fndiscamtk { get; set; }//flo

        [Column("FNDISCPCN")]
        public decimal? fndiscpcn { get; set; }//flo

        [Column("FNPAYAMT")]
        public decimal? fnpayamt { get; set; }//flo

        [Column("FNPAYAMTKE")]
        public decimal? fnpayamtke { get; set; }//flo

        [Column("FNPRICE ")]
        public decimal? fnprice { get; set; }//flo

        [Column("FNPRICEKE")]
        public decimal? fnpriceke { get; set; }//flo

        [Column("FNPRODAGE")]
        public decimal? fnprodage { get; set; }//flo

        [Column("FNQTY ")]
        public decimal? fnqty { get; set; }//flo

        [Column("FNQTYATDAT")]
        public decimal? fnqtyatdat { get; set; }//flo

        [Column("FNREFQTY")]
        public decimal? fnrefqty { get; set; }//flo

        [Column("FNSTQTY ")]
        public decimal? fnstqty { get; set; }//flo

        [Column("FNSTUMQTY")]
        public decimal? fnstumqty { get; set; }//flo

        [Column("FNUMQTY ")]
        public decimal? fnumqty { get; set; }//flo

        [Column("FNVATAMT")]
        public decimal? fnvatamt { get; set; }//flo

        [Column("FNVATPORT")]
        public decimal? fnvatport { get; set; }//flo

        [Column("FNVATPORTA")]
        public decimal? fnvatporta { get; set; }//flo

        [Column("FNVATRATE")]
        public decimal? fnvatrate { get; set; }//flo

        [Column("FNWTAXAMT")]
        public decimal? fnwtaxamt { get; set; }//flo

        [Column("FNWTAXAMTK")]
        public decimal? fnwtaxamtk { get; set; }//flo

        [Column("FNWTAXRATE")]
        public decimal? fnwtaxrate { get; set; }//flo

        [Column("FNXRATE ")]
        public decimal? fnxrate { get; set; }//flo

        [Column("FTDATETIME")]
        public DateTime? ftdatetime { get; set; }//tim

        [Column("FTLASRECAL")]
        public string? ftlasrecal { get; set; }//str

        [Column("FTLASTEDIT")]
        public DateTime? ftlastedit { get; set; }//tim

        [Column("FTLASTUPD")]
        public DateTime? ftlastupd { get; set; }//tim

        [Column("FTRECEIVE")]
        public string? ftreceive { get; set; }//str

        [Column("FTSRCUPD")]
        public string? ftsrcupd { get; set; }//str

        [Column("FTXFER")]
        public string? ftxfer { get; set; }//str

        //   Corp* Corp       `gorm:"foreignKey:FCCORP;references:FCSKID;" json:"corp"`
        [ForeignKey(nameof(fccorp))]
        public Corp? corp { get; set; }

        //Branch* Branch     `gorm:"foreignKey:FCBRANCH;references:FCSKID;" json:"branch"`
        [ForeignKey(nameof(fcbranch))]
        public Branch? branch { get; set; }

        //Dept* Department `gorm:"foreignKey:FCDEPT;references:FCSKID;" json:"department"`
        [ForeignKey(nameof(fcdept))]
        public Department? department { get; set; }

        //Sect* Section    `gorm:"foreignKey:FCSECT;references:FCSKID;" json:"section"`
        [ForeignKey(nameof(fcsect))]
        public Sect? section { get; set; }

        //Job* Job        `gorm:"foreignKey:FCJOB;references:FCSKID;" json:"job"`
        [ForeignKey(nameof(fcjob))]
        public Job? job { get; set; }

        //Glhead* Glhead     `gorm:"foreignKey:FCGLHEAD;references:FCSKID;" json:"glhead"`
        [ForeignKey(nameof(fcglhead))]
        public GlHead? glhead { get; set; }

        //Glref* Glref      `gorm:"foreignKey:FCGLREF;references:FCSKID;" json:"glref"`
        [ForeignKey(nameof(fcglref))]
        public GlRef? glref { get; set; }

        //Prod* Product    `gorm:"foreignKey:FCPROD;references:FCSKID;" json:"prod"`
        [ForeignKey(nameof(fcprod))]
        public Product? product { get; set; }

        //Unit* Unit       `gorm:"foreignKey:FCUM;references:FCSKID;" json:"unit"`
        [ForeignKey(nameof(fcum))]
        public Unit? unit { get; set; }

        //UnitSTD* Unit       `gorm:"foreignKey:FCUMSTD;references:FCSKID;" json:"unit_standard"`
        [ForeignKey(nameof(fcumstd))]
        public Unit? unit_standard { get; set; }

        //Stum* Unit       `gorm:"foreignKey:FCSTUM;references:FCSKID;" json:"stum"`
        [ForeignKey(nameof(fcstum))]
        public Unit? stum { get; set; }

        //StumStd* Unit       `gorm:"foreignKey:FCSTUMSTD;references:FCSKID;" json:"stum_std"`
        [ForeignKey(nameof(fcstumstd))]
        public Unit? stum_std { get; set; }

        //WHouse* Whs        `gorm:"foreignKey:FCWHOUSE;references:FCSKID;" json:"whouse"`
        [ForeignKey(nameof(fcwhouse))]
        public Whs? whouse { get; set; }

        //Proj* Proj       `gorm:"foreignKey:FCPROJ;reference:FCSKID;" json:"proj"`
        [ForeignKey(nameof(fcproj))]
        public Project? proj { get; set; }

        //Gl* Gl         `gorm:"foreignKey:FCGL;references:FCSKID;" json:"gl"`
        [ForeignKey(nameof(fcgl))]
        public Gl? gl { get; set; }

        //CreatedBy* Employee   `gorm:"foreignKey:FCCREATEBY;references:FCSKID;" json:"created_by"`
        [ForeignKey(nameof(fccreateby))]
        public Employee? created_by { get; set; }

        //UpdatedBy* Employee   `gorm:"foreignKey:FCCORRECTB;references:FCSKID;" json:"updated_by"`
        [ForeignKey(nameof(fccorrectb))]
        public Employee? updated_by { get; set; }
    }
}
