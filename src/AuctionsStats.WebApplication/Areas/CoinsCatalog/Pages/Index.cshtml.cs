using AuctionsStats.WebApplication.ServicesLayer.Coins;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuctionsStats.WebApplication.Areas.CoinsCatalog.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ICoinService coinService;

    public IEnumerable<CoinListViewModel> Coins { get; private set; }

    public IndexModel(ILogger<IndexModel> logger, ICoinService coinService)
    {
        _logger = logger;
        this.coinService = coinService ?? throw new ArgumentNullException(nameof(coinService));
    }

    public void OnGet()
    {
        this.Coins = coinService.GetCoinsList();
    }
}
