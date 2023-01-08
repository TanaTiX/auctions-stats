namespace AuctionsStats.WebApplication.ServicesLayer.Coins
{
    public interface ICoinService
    {
        Task<Guid> CreateCoinAsync(CreateCoinCommand input);

        Task DeleteCoin(int id);

        Task DeleteCoinAsync(int id);
        Task<CoinDetailViewModel> GetCoinDetailAsync(Guid id);
        IEnumerable<CoinListViewModel> GetCoinsList();
    }
}