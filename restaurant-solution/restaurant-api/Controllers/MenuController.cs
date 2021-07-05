using Microsoft.AspNetCore.Mvc;
using restaurant_application.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant_api.Controllers
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
