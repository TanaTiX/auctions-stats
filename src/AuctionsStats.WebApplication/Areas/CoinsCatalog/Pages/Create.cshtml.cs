using System;
using System.Collections.Generic;
using AuctionsStats.WebApplication.ServicesLayer.Coins;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuctionsStats.WebApplication.Areas.CoinsCatalog.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public CreateCoinCommand Input { get; set; }
        private readonly ICoinService service;

        public CreateModel(ICoinService service)
        {
            this.service = service;
        }

        public void OnGet()
        {
            Input = new CreateCoinCommand();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var id = await this.service.CreateCoinAsync(this.Input);
                    return RedirectToPage("View", new { id });
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "Произошла ошибка при сохранении монеты"
                    );
            }

            return Page();
        }
    }
}