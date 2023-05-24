using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PodCast.DAL;

namespace PodCast.ViewComponenets
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public HeaderViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var header = await _dbContext.Headers.FirstOrDefaultAsync();

            return View(header);
        }
    }
}
