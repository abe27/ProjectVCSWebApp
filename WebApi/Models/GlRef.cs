using Microsoft.VisualBasic;
using System.Drawing;
using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    [Table("GLREF")]
    public class GlRef
    {
        [Column("FCATSTEP")]
        // string 
        public string? fcatstep { get; set; }

        [Column("FCBOOK")]
        // string 
        public string? fcbook { get; set; }

        [Column("FCBRANCH")]
        // string 
        public string? fcbranch { get; set; }

        [Column("FCCODE")]
        // string 
        public string? fccode { get; set; }

        [Column("FCCOOR")]
        // string 
        public string? fccoor { get; set; }

        [Column("FCCORP")]
        // string 
        public string? fccorp { get; set; }

        [Column("FCCORRECTB")]
        // string 
        public string? fccorrectb { get; set; }

        [Column("FCCREATEBY")]
        // string 
        public string? fccreateby { get; set; }

        [Column("FCCREATETY")]
        // string 
        public string? fccreatety { get; set; }

        [Column("FCDATASER")]
        // string 
        public string? fcdataser { get; set; }

        [Column("FCDELICOOR")]
        // string 
        public string? fcdelicoor { get; set; }

        [Column("FCDEPT")]
        // string 
        public string? fcdept { get; set; }

        [Column("FCEAFTERR")]
        // string 
        public string? fceafterr { get; set; }

        [Column("FCFRWHOUSE")]
        // string 
        public string? fcfrwhouse { get; set; }

        [Column("FCGID")]
        // string 
        public string? fcgid { get; set; }

        [Column("FCGLHEAD")]
        // string 
        public string? fcglhead { get; set; }

        [Column("FCJOB")]
        // string 
        public string? fcjob { get; set; }

        [Column("FCPROJ")]
        // string 
        public string? fcproj { get; set; }

        [Column("FCREFNO")]
        // string 
        public string? fcrefno { get; set; }

        [Column("FCREFTYPE")]
        // string 
        public string? fcreftype { get; set; }

        [Column("FCRFTYPE")]
        // string 
        public string? fcrftype { get; set; }

        [Column("FCSECT")]
        // string 
        public string? fcsect { get; set; }

        [Key]
        [StringLength(8)]
        [Column("FCSKID")]
        // string 
        public string? fcskid { get; set; }

        [Column("FCSTEP")]
        // string 
        public string? fcstep { get; set; }

        [Column("FCTOWHOUSE")]
        // string 
        public string? fctowhouse { get; set; }

        [Column("FCVATCOOR")]
        // string 
        public string? fcvatcoor { get; set; }

        [Column("FDDATE")]
        // time.Ti
        public DateTime? fddate { get; set; }

        [Column("FDRECEDATE")]
        // time.Ti
        public DateTime? fdrecedate { get; set; }

        [Column("FDDUEDATE")]
        // time.Ti
        public DateTime? fdduedate { get; set; }

        [Column("FIMILLISEC")]
        // int64  
        public int? fimillisec { get; set; }

        [Column("FNAFTDEP")]
        // float64
        public decimal? fnaftdep { get; set; }

        [Column("FNAFTDEPKE")]
        // float64
        public decimal? fnaftdepke { get; set; }

        [Column("FNAMT")]
        // float64
        public decimal? fnamt { get; set; }

        [Column("FNXRATE")]
        // float64
        public decimal? fnxate { get; set; }

        [Column("FNAMTKE")]
        // float64
        public decimal? fnamtke { get; set; }

        [Column("FNVATAMTKE")]
        // float64
        public decimal? fnvatamtke { get; set; }

        [Column("FNCREDTERM")]
        // int    
        public int? fncredterm { get; set; }

        [Column("FCVATTYPE")]
        // string 
        public string? fcvattype { get; set; }

        [Column("FNVATRATE")]
        // float64
        public decimal? fnvatrate { get; set; }

        [Column("FNVATAMT")]
        // float64
        public decimal? fnvatamt { get; set; }

        [Column("FNPAYAMT")]
        // float64
        public decimal? fnpayamt { get; set; }

        [Column("FNSPAYAMT")]
        // float64
        public decimal? fnspayamt { get; set; }

        [Column("FNBEFOAMT")]
        // float64
        public decimal? fnbefoamt { get; set; }

        [Column("FCVATISOUT")]
        // string 
        public string? fcvatisout { get; set; }

        [Column("FCISCASH")]
        // string 
        public string? fciscash { get; set; }

        [Column("FCHASRET")]
        // string 
        public string? fcchasret { get; set; }

        [Column("FCVATDUE")]
        // string 
        public string? fcvatdue { get; set; }

        [Column("FNSTOCKUPD")]
        // float64
        public decimal? fnstockupd { get; set; }

        [Column("FTDATETIME")]
        // time.Ti
        public DateTime? ftdatetime { get; set; }

        [Column("FTLASTEDIT")]
        // time.Ti
        public DateTime? ftlastedit { get; set; }

        [Column("FTLASTUPD")]
        // time.Ti
        public DateTime? ftlastupd { get; set; }

        [Column("FCLUPDAPP")]
        // string 
        public string? fclupdapp { get; set; }

        [Column("FMMEMDATA")]
        // string 
        public string? fmmemdata { get; set; }

        [Column("FCCREATEAP")]
        // string 
        public string? fccreateap { get; set; }

        //BOOK
        [ForeignKey(nameof(fcbook))]
        public Book? book { get; set; }

        //BRANCH
        [ForeignKey(nameof(fcbranch))]
        public Branch? branch { get; set; }

        //COOR
        [ForeignKey(nameof(fccoor))]
        public Coor? coor { get; set; }

        //CORP
        [ForeignKey(nameof(fccorp))]
        public Corp? corp { get; set; }

        //CORRECTB
        [ForeignKey(nameof(fccorrectb))]
        public Employee? created_by { get; set; }

        //DEPT
        [ForeignKey(nameof(fcdept))]
        public Department? department { get; set; }

        //JOB
        [ForeignKey(nameof(fcjob))]
        public Job? job { get; set; }

        //PROJ
        [ForeignKey(nameof(fcproj))]
        public Project? project { get; set; }

        //TOWHOUSE
        [ForeignKey(nameof(fctowhouse))]
        public Whs? to_whs { get; set; }

        //FROMWHOUSE
        [ForeignKey(nameof(fcfrwhouse))]
        public Whs? from_whs { get; set; }
    }
}
