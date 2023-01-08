using AuctionsStats.WebApplication.ServicesLayer.Coins;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuctionsStats.WebApplication.Areas.CoinsCatalog.Pages
{
    public class ViewModel : PageModel
    {
        private readonly ICoinService service;

        public ViewModel(ICoinService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public CoinDetailViewModel Coin { get; private set; }
        public async Task OnGet(Guid id)
        {
            this.Coin = await this.service.GetCoinDetailAsync(id);
        }
    }
}
