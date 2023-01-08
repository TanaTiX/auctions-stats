using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuctionsStats.WebApplication.ServicesLayer.Coins
{
    public class EditCoinBase
    {
        [Required]
        [StringLength(100)]
        [DisplayName("Наименование")]
        public string Name { get; set; }

        [Range(0, 2100)]
        [DisplayName("Год выпуса")]
        public int? Year { get; set; }

        [DisplayName("Номинал")]
        public string Nominal { get; set; }

        [DisplayName("Валюта")]
        public string Currency { get; set; }

        [DisplayName("Каталожный номер")]
        public string ReferenceNo { get; set; }
    }
}