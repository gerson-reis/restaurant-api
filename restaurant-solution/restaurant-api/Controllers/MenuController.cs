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
       public async Task<IActionResult> UpdatePlate(int id, string nome)
        {
            var service =  new AddNewItemToMenuService();
            await service.UpdatePlate(id, nome);
            return View();
        }
    }
    public class RestauranteController : Controller
    { 
        public async Task<IActionResult> AddRestaurant(string nome, string adress)
        {
            var service = new AddNewRestaurantService();
            await service.Add(nome, adress);
            return View();
        }
    }

}
