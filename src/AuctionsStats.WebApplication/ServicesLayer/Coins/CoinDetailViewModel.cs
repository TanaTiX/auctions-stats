using System.ComponentModel;

namespace AuctionsStats.WebApplication.ServicesLayer.Coins
{
    public class CoinDetailViewModel
    {
        public Guid Id { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; }

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