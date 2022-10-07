using front_to_back.DAL;
using front_to_back.ViewModels.Work;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace front_to_back.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public WorkController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public async Task<IActionResult> Index()
        {
            var catagory = await _appDbContext.Catagories.ToListAsync();
           
            var model = new WorkIndexViewModel
            {
                Catagories = catagory,
               
            };
            return View(model);
        }
       
    }
}
