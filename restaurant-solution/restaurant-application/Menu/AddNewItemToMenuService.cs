using Restaurant.Repository;
using restaurant_domain;
using System.Threading.Tasks;

namespace Restaurant.Application.Menu
{
    public class AddNewItemToMenuService
    {
        //um metodo que recebe os paramentros de um novo prato e adiciona no menu do restaurante escolhido
        public async Task Add(string nome, decimal price)
        {
            var newPlate = new Plate(nome);
            var repository = new PlateRepository();
            await repository.Add(newPlate);
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
}
