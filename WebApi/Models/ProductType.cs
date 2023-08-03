using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    [Table("PRODTYPE")]
    public class ProductType
    {
        [Key]
        [Column("FCCODE")]
        public string? fccode { get; set; }

        [Column("FCNAME")]
        public string? fcname { get; set; }

        [Column("FCNAME2")]
        public string? fcname2 { get; set; }
    }
}
