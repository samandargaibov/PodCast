using Microsoft.AspNetCore.Mvc;
using PodCast.DAL;

namespace PodCast.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var contacts = _dbContext.Contacts.FirstOrDefault();

            return View(contacts);
        }
    }
}
