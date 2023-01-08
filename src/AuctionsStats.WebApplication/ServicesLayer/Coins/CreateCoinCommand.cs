using AuctionsStats.Data;

namespace AuctionsStats.WebApplication.ServicesLayer.Coins
{
    public class CreateCoinCommand : EditCoinBase
    {
        internal Coin ToCoin()
        {
            return new Coin
            {
                Name = Name,
                Year = Year,
                Nominal = Nominal,
                Currency = Currency,
                ReferenceNo = ReferenceNo,
            };
        }
    }
}