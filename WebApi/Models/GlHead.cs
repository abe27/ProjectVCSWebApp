using Microsoft.AspNetCore.Http.HttpResults;
using System.Reflection.Emit;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class GlHead
    {
        [Key]
        [StringLength(8)]
        [Column("FCSKID")]// string    `gorm:"primaryKey;column:FCSKID;size:8;unique;index;" json:"fcskid"  form:"fcskid" `
        public string? fcskid { get; set; }

        [Column("FCDATASER")]// string    `gorm:"column:FCDATASER;" json:"fcdataser"  form:"fcdataser" `
        public string? fcdataser { get; set; }

        [Column("FCCORP")]// string    `gorm:"column:FCCORP;" json:"fccorp"  form:"fccorp" `
        public string? fccorp { get; set; }

        [Column("FCBRANCH")]// string    `gorm:"column:FCBRANCH;" json:"fcbranch"  form:"fcbranch" `
        public string? fcbranch { get; set; }

        [Column("FCSTEP")]// string    `gorm:"column:FCSTEP;" json:"fcstep"  form:"fcstep" `
        public string? fcstep { get; set; }
        //E
        [Column("FCSTYLE")]// string    `gorm:"column:FCSTYLE;" json:"fcstyle"  form:"fcstyle" `
        public string? fcstyle { get; set; }
        //A
        [Column("FCLINK")]// string    `gorm:"column:FCLINK;" json:"fclink"  form:"fclink" `
        public string? fclink { get; set; }
        // $C
        [Column("FDDATE")]// time.Time `gorm:"column:FDDATE;" json:"fddate"  form:"fddate" default:"now"`
        public DateTime? fdate { get; set; }

        [Column("FCACCBOOK")]//  string    `gorm:"column:FCACCBOOK;" json:"fcaccbook"  form:"fcaccbook" `
        public string? fcaccbook { get; set; }

        [Column("FCCODE")]//     string    `gorm:"column:FCCODE;" json:"fccode"  form:"fccode" `
        public string? fccode { get; set; }

        [Column("FMREMARK")]//   string    `gorm:"column:FMREMARK;" json:"fmremark"  form:"fmremark" `
        public string? fmremark { get; set; }

        [Column("FMREMARK2")]//  string    `gorm:"column:FMREMARK2;" json:"fmremark2"  form:"fmremark2" `
        public string? fmremark2 { get; set; }

        [Column("FMREMARK3")]//  string    `gorm:"column:FMREMARK3;" json:"fmremark3"  form:"fmremark3" `
        public string? fmremark3 { get; set; }

        [Column("FCCREATEBY")]// string    `gorm:"column:FCCREATEBY;" json:"fccreateby"  form:"fccreateby" `
        public string? fccreateby { get; set; }

        [Column("FCCORRECTB")]// string    `gorm:"column:FCCORRECTB;" json:"fccorrectb"  form:"fccorrectb" `
        public string? fccorrectb { get; set; }

        [Column("FCEAFTERR")]//  string    `gorm:"column:FCEAFTERR;" json:"fceafterr"  form:"fceafterr" `
        public string? fceafterr { get; set; }//E

        [Column("FCATSTEP")]//   string    `gorm:"column:FCATSTEP;" json:"fcatstep"  form:"fcatstep" `
        public string? fcatstep { get; set; }//I

        [Column("FNLOCKED")]// float64   `gorm:"column:FNLOCKED;" json:"fnlocked"  form:"fnlocked" `    //0
        public decimal fnlocked { get; set; }

        [Column("FCGID")]//      string    `gorm:"column:FCGID;" json:"fcgid"  form:"fcgid" `
        public string? fcgid { get; set; }

        [Column("FCCREATEAP")]// string `gorm:"column:FCCREATEAP;" json:"fccreateap"  form:"fccreateap" `
        public string? fccreateap { get; set; }

        [Column("FCLUPDAPP")]// string `gorm:"column:FCLUPDAPP;" json:"fclupdapp"  form:"fclupdapp" `
        public string? fclupdapp { get; set; }

        [Column("FIMILLISEC")]// int64     `gorm:"column:FIMILLISEC;" json:"fimillisec"  form:"fimillisec" 
        public int? fimillisec { get; set; } //`

        [Column("FTDATETIME")]// time.Time `gorm:"column:FTDATETIME;" json:"ftdatetime"  form:"ftdatetime" 
        public DateTime? ftdatetime { get; set; } //default:"now"`

        [Column("FTLASTEDIT")]// time.Time `gorm:"column:FTLASTEDIT;" json:"ftlastedit"  form:"ftlastedit" 
        public DateTime? ftlastedit { get; set; } //default:"now"`

        [Column("FTLASTUPD")]// time.Time `gorm:"column:FTLASTUPD;" json:"ftlastupd"  form:"ftlastupd" 
        public DateTime? ftlastupd { get; set; } //default:"now"`

        //Corp* Corp     `gorm:"foreignKey:FCCORP;references:FCSKID;" json:"corp"`
        [ForeignKey(nameof(fccorp))]
        public required Corp corp { get; set; }

        //Branch* Branch   `gorm:"foreignKey:FCBRANCH;references:FCSKID;" json:"branch"`
        [ForeignKey(nameof(fcbranch))]
        public required Branch branch { get; set; }

        //Accbook* Accbook  `gorm:"foreignKey:FCACCBOOK;references:FCSKID;" json:"accbook"`
        [ForeignKey(nameof(fcaccbook))]
        public required AccountingBook accbook { get; set; }

        //CreatedBy* Employee `gorm:"foreignKey:FCCREATEBY;references:FCSKID;" json:"created_by"`
        [ForeignKey(nameof(fccreateby))]
        public Employee? created_by { get; set; }

        //UpdatedBy* Employee `gorm:"foreignKey:FCCORRECTB;references:FCSKID;" json:"updated_by"`
        [ForeignKey(nameof(fccorrectb))]
        public Employee? updated_by { get; set; }
    }
}
