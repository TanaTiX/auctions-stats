using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionsStats.Data
{
    [Table("COINS")]
    public class Coin
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("NAME")]
        [Required]
        public string Name { get; set; }

        [Column("ISSUE_YEAR")]
        public int? Year { get; set; }

        [Column("NOMINAL")]
        public string Nominal { get; set; }

        [Column("CURRENCY")]
        public string Currency { get; set; }

        [Column("REFERENCE_NO")]
        public string ReferenceNo { get; set; }

        [Column("LAST_MODIFIED")]
        [Required]
        public DateTime LastModified { get; set; }
    }
}
