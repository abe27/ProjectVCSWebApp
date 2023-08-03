using Microsoft.AspNetCore.Http.HttpResults;
using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Gl
    {
        [Column("FCACCHART")]// string `gorm:"column:FCACCHART;" json:"fcacchart"  form:"fcacchart" `
        public string? fcacchart { get; set; }

        [Column("FCACLINK")]// string `gorm:"column:FCACLINK;" json:"fcaclink"  form:"fcaclink" `
        public string? fcaclink { get; set; }

        [Column("FCATSTEP")]// string `gorm:"column:FCATSTEP;" json:"fcatstep"  form:"fcatstep" `
        public string? fcatstep { get; set; }

        [Column("FCBRANCH")]// string `gorm:"column:FCBRANCH;" json:"fcbranch"  form:"fcbranch" `
        public string? fcbranch { get; set; }

        [Column("FCCORP")]// string `gorm:"column:FCCORP;" json:"fccorp"  form:"fccorp" `
        public string? fccorp { get; set; }

        [Column("FCCORRECTB")]// string `gorm:"column:FCCORRECTB;" json:"fccorrectb"  form:"fccorrectb" `
        public string? fccorrectb { get; set; }

        [Column("FCCREATEAP")]// string `gorm:"column:FCCREATEAP;" json:"fccreateap"  form:"fccreateap" `
        public string? fccreateap { get; set; }//$.

        [Column("FCCREATEBY")]// string `gorm:"column:FCCREATEBY;" json:"fccreateby"  form:"fccreateby" `
        public string? fccreateby { get; set; }

        [Column("FCDATASER")]// string `gorm:"column:FCDATASER;" json:"fcdataser"  form:"fcdataser" `
        public string? fcdataser { get; set; }// $$$+

        [Column("FCDEPT")]// string `gorm:"column:FCDEPT;" json:"fcdept"  form:"fcdept" `
        public string? fcdept { get; set; }

        [Column("FCEAFTERR")]// string `gorm:"column:FCEAFTERR;" json:"fceafterr"  form:"fceafterr" `
        public string? fceafterr { get; set; }// E

        [Column("FCGLHEAD")]// string `gorm:"column:FCGLHEAD;" json:"fcglhead"  form:"fcglhead" `
        public string? fcglhead { get; set; }

        [Column("FCJOB")]// string `gorm:"column:FCJOB;" json:"fcjob"  form:"fcjob" `
        public string? fcjob { get; set; }

        [Column("FCLUPDAPP")]// string `gorm:"column:FCLUPDAPP;" json:"fclupdapp"  form:"fclupdapp" `
        public string? fclupdapp { get; set; }// $.

        [Column("FCPROJ")]// string `gorm:"column:FCPROJ;" json:"fcproj"  form:"fcproj" `
        public string? fcproj { get; set; }

        [Column("FCRECALBY")]// string `gorm:"column:FCRECALBY;" json:"fcrecalby"  form:"fcrecalby" `
        public string? fcrecalby { get; set; }

        [Column("FCSECT")]// string `gorm:"column:FCSECT;" json:"fcsect"  form:"fcsect" `
        public string? fcsect { get; set; }

        [Column("FCSEQ")]// string `gorm:"column:FCSEQ;" json:"fcseq"  form:"fcseq" `
        public string? fcseq { get; set; }

        [Column("FCSKID")]// string `gorm:"primaryKey;column:FCSKID;size:8;unique;index;" json:"fcskid"  form:"fcskid" `
        public string? fcskid { get; set; }

        [Column("FDDATE")]// time.Time `gorm:"column:FDDATE;" json:"fddate"  form:"fddate" d
        public string? fddate { get; set; }

        [Column("FIMILLISEC")]// int64     `gorm:"column:FIMILLISEC;" json:"fimillisec"  form:"fimillisec" `
        public string? fimillisec { get; set; }

        [Column("FNAMT")]// float64   `gorm:"column:FNAMT;" json:"fnamt"  form:"fnamt" `
        public string? fnamt { get; set; }

        [Column("FNCALLINE")]// float64   `gorm:"column:FNCALLINE;" json:"fncalline"  form:"fncalline" `
        public string? fncalline { get; set; }// 0

        [Column("FTDATETIME")]// time.Time `gorm:"column:FTDATETIME;" json:"ftdatetime"  form:"ftdatetime" d
        public string? ftdatetime { get; set; }

        [Column("FTLASTEDIT")]// time.Time `gorm:"column:FTLASTEDIT;" json:"ftlastedit"  form:"ftlastedit" d
        public string? ftlastedit { get; set; }

        [Column("FTLASTUPD")]// time.Time `gorm:"column:FTLASTUPD;" json:"ftlastupd"  form:"ftlastupd" d
        public string? ftlastupd { get; set; }

        //Corp* Corp       `gorm:"foreignKey:FCCORP;references:FCSKID;" json:"corp"`
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
        public Sect? sect { get; set; }

        //Glhead* Glhead     `gorm:"foreignKey:FCGLHEAD;references:FCSKID;" json:"glhead"`
        [ForeignKey(nameof(fcglhead))]
        public GlHead? glhead { get; set; }

        //Acchart* Acchart    `gorm:"foreignKey:FCACCHART;references:FCSKID;" json:"acchart"`
        //Job* Job        `gorm:"foreignKey:FCJOB;references:FCSKID;" json:"job"`
        //CreatedBy* Employee   `gorm:"foreignKey:FCCREATEBY;references:FCSKID;" json:"created_by"`
        //UpdatedBy* Employee   `gorm:"foreignKey:FCCORRECTB;references:FCSKID;" json:"updated_by"`
    }
}
