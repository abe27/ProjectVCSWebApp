using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace WebApi.Models
{
    public class OrderHead
    {
        [Column("FCBOOK")]
        public string? fcbook { get; set; }//str

        [Column("FCBRANCH")]
        public string? fcbranch { get; set; }//str

        [Column("FCCODE")]
        public string? fccode { get; set; }//str

        [Column("FCCOOR")]
        public string? fccoor { get; set; }//str

        [Column("FCCORP")]
        public string? fccorp { get; set; }//str

        [Column("FCCORRECTB")]
        public string? fccorrectb { get; set; }//str

        [Column("FCCREATEAP")]
        public string? fccreateap { get; set; }//str

        [Column("FCCREATEBY")]
        public string? fccreateby { get; set; }//str

        [Column("FCDATASER")]
        public string? fcdataser { get; set; }//str

        [Column("FCDELICOOR")]
        public string? fcdelicoor { get; set; }//str

        [Column("FCDEPT")]
        public string? fcdept { get; set; }//str

        [Column("FCEAFTERR")]
        public string? fceafterr { get; set; }//str

        [Column("FCISPDPART")]
        public string? fcispdpart { get; set; }//str

        [Column("FCJOB")]
        public string? fcjob { get; set; }//str

        [Column("FCPAYTERM")]
        public string? fcpayterm { get; set; }//str

        [Column("FCPROJ")]
        public string? fcproj { get; set; }//str

        [Column("FCREFNO")]
        public string? fcrefno { get; set; }//str

        [Column("FCREFTYPE")]
        public string? fcreftype { get; set; }//str

        [Column("FCRFTYPE")]
        public string? fcrftype { get; set; }//str

        [Column("FCSECT")]
        public string? fcsect { get; set; }//str

        [Column("FCSKID")]
        public string? fcskid { get; set; }//str

        [Column("FCSTEP")]
        public string? fcstep { get; set; }//str

        [Column("FCVATISOUT")]
        public string? fcvatisout { get; set; }//str

        [Column("FCVATTYPE")]
        public string? fcvattype { get; set; }//str

        [Column("FDAPPROVE")]
        public DateTime? fdapprove { get; set; }//tim

        [Column("FDDATE")]
        public DateTime? fddate { get; set; }//tim

        [Column("FDDUEDATE")]
        public DateTime? fdduedate { get; set; }//tim

        [Column("FDRECEDATE")]
        public string? fdrecedate { get; set; }//tim

        [Column("FDREQDATE")]
        public DateTime? fdreqdate { get; set; }//tim

        [Column("FIMILLISEC")]
        public int? fimillisec { get; set; }//int

        [Column("FMDOCFLOW")]
        public string? fmdocflow { get; set; }//str

        [Column("FMEXTRATAG")]
        public string? fmextratag { get; set; }//str

        [Column("FMMEMDATA")]
        public string? fmmemdata { get; set; }//str

        [Column("FNAMT")]
        public decimal? fnamt { get; set; }//flo

        [Column("FNAMTKE")]
        public decimal? fnamtke { get; set; }//flo

        [Column("FNCREDTERM")]
        public int? fncredterm { get; set; }//int

        [Column("FNVATAMT")]
        public decimal? fnvatamt { get; set; }//flo

        [Column("FNVATAMTKE")]
        public decimal? fnvatamtke { get; set; }//flo

        [Column("FNVATRATE")]
        public decimal? fnvatrate { get; set; }//flo

        [Column("FNXRATE")]
        public decimal? fnxrate { get; set; }//flo

        [Column("FTDATETIME")]
        public DateTime? ftdatetime { get; set; }//tim

        [Column("FTLASTEDIT")]
        public DateTime? ftlastedit { get; set; }//tim

        [Column("FTLASTUPD")]
        public DateTime? ftlastupd { get; set; }//tim

        //Corp*Corp`gorm:"foreignKey:FCCORP;references:FCSKID;"json:"corp"`
        [ForeignKey(nameof(fccorp))]
        public Corp? corp { get; set; }

        //Book*Booking`gorm:"foreignKey:FCBOOK;references:FCSKID;"json:"book"`
        [ForeignKey(nameof(fcbook))]
        public Book? book { get; set; }

        //Branch*Branch`gorm:"foreignKey:FCBRANCH;references:FCSKID;"json:"branch"`
        [ForeignKey(nameof(fcbranch))]
        public Branch? branch { get; set; }

        //Dept*Department`gorm:"foreignKey:FCDEPT;references:FCSKID;"json:"department"`
        [ForeignKey(nameof(fcdept))]
        public Department? department { get; set; }

        //Sect*Section`gorm:"foreignKey:FCSECT;references:FCSKID;"json:"section"`
        [ForeignKey(nameof(fcsect))]
        public Sect? section { get; set; }

        //Job*Job`gorm:"foreignKey:FCJOB;references:FCSKID;"json:"job"`
        [ForeignKey(nameof(fcjob))]
        public Job? job { get; set; }

        //Coor*Coor`gorm:"foreignKey:FCCOOR;references:FCSKID;"json:"coor"`
        [ForeignKey(nameof(fccoor))]
        public Coor? coor { get; set; }

        //CreatedBy*Employee`gorm:"foreignKey:FCCREATEBY;references:FCSKID;"json:"created_by"`
        [ForeignKey(nameof(fccreateby))]
        public Employee? created_by { get; set; }

        //UpdatedBy*Employee`gorm:"foreignKey:FCCORRECTB;references:FCSKID;"json:"updated_by"`
        [ForeignKey(nameof(fccorrectb))]
        public Employee? updated_by { get; set; }

        //Proj*Proj`gorm:"foreignKey:FCPROJ;references:FCSKID;"json:"proj"`
        [ForeignKey(nameof(fcproj))]
        public Project? proj { get; set; }

        //DeliverTo*Coor`gorm:"foreignKey:FCDELICOOR;references:FCSKID;"json:"delivery_to"`
        [ForeignKey(nameof(fcdelicoor))]
        public Coor? delivery_to { get; set; }

        //Payterm*Payterm`gorm:"foreignKey:FCPAYTERM;references:FCSKID;"json:"paymenterm"`
        [ForeignKey(nameof(fcpayterm))]
        public PaymentTerm? paymen_term { get; set; }

    }
}
