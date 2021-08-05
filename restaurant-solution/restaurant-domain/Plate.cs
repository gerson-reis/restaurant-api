using Restaurant.Domain;
using System;

namespace restaurant_domain
{
    public class Plate : BaseEntity
    {
        public Plate()
        {

        }

        public Plate(string name)
        {
            Name = name;
            //Price = price;
        }

        public void SetName(string name)
        {
            Name = name;
        }


        public void TiraIngrediente()
        {

        }

        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice;
        }


        public string Name { get; private set; }
        public decimal? Cost { get; private set; }
        public decimal? Price { get; private set; }
        public decimal? OldPrice { get; private set; }
    }
}
