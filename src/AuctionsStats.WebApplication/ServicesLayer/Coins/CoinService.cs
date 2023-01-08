using AuctionsStats.Data;
using Microsoft.EntityFrameworkCore;

namespace AuctionsStats.WebApplication.ServicesLayer.Coins
{
    public class CoinService : ICoinService
    {
        private readonly AppDataContext dataContext;

        public CoinService(AppDataContext dataContext)
        {
            this.dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
        }

        public async Task<Guid> CreateCoinAsync(CreateCoinCommand command)
        {
            var coin = command.ToCoin();
            await this.dataContext.AddAsync(coin);
            await this.dataContext.SaveChangesAsync();
            return coin.Id;
        }

        public Task DeleteCoin(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCoinAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CoinDetailViewModel> GetCoinDetailAsync(Guid id)
        {
            return await this.dataContext.Coins
                .Where(o => o.Id == id)
                .Select(o => new CoinDetailViewModel
                {
                    Id = o.Id,
                    Name = o.Name,
                    Nominal = o.Nominal,
                    Year = o.Year,
                    Currency = o.Currency,
                    ReferenceNo = o.ReferenceNo,
                    })
                .SingleOrDefaultAsync();
        }

        public IEnumerable<CoinListViewModel> GetCoinsList()
        {
            return this.dataContext.Coins.Select(o => new CoinListViewModel(o.Id, o.Name, o.Year, o.Nominal)).ToList();
        }
    }
}