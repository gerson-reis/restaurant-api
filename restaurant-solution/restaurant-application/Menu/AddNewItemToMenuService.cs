using restaurant_domain;
using restaurant_repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_application.Menu
{
    public class AddNewItemToMenuService
    {
        //um metodo que recebe os paramentros de um novo prato e adiciona no menu do restaurante escolhido
        public async Task Add(string nome, decimal price)
        {
            var newPlate = new Plate(nome, price);
            var repository = new PlateRepository();
            await  repository.Add(newPlate);
        }

        public async Task UpdatePlate(int id, string nome)
        {
            var repository = new PlateRepository();
            //Oi
            var plate = await repository.GetById(id);
            plate.SetName(nome);

            await repository.Update(plate);
        }
    }

    public class AddNewRestaurantService
    {
        public async Task Add(string nome, string adress)

        {
            var newRestaurant = new Restaurante(nome, adress);
            var repository = new RestaurantRepository();
            await repository.Add(newRestaurant);
        }
       // public async Task UpdateRestaurant(int id, string nome)
        //{
         //   var repository = new RestaurantRepository();

           // var restaurante = await repository.GetById(id);
            //restaurante.SetNome(nome);

            //Sawait repository.Update(restaurante);
        }
    }

}
