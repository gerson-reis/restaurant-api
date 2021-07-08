using restaurant_domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_repository
{
    public class PlateRepository
    {
        public async Task Add(Plate plate)
        { 
            // adiciona um novo prato na base de dados atraves do ORM
        }

        public async Task<Plate> GetById(int id)
        {
            return null;
        }

        public async Task Update(Plate plate)
        {
            // adiciona um novo prato na base de dados atraves do ORM
        }
    }

    public class RestaurantRepository
    {
        public async Task Add(Restaurante restaurante)
        {

        }
    }
}
