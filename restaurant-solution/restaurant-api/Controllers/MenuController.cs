using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.Menu;
using System.Threading.Tasks;

namespace Restaurant.API.Controllers
{
    public class MenuController : Controller
    {
        public async Task<IActionResult> AddPlate(decimal price, string nome)
        {
            var service = new AddNewItemToMenuService();
            await service.Add(nome, price);
            return View();
        }
    }
}
