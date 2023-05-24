using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PodCast.DAL;

namespace PodCast.ViewComponenets
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var header = await _dbContext.Footers.FirstOrDefaultAsync();

            return View(header);
        }
    }
}
