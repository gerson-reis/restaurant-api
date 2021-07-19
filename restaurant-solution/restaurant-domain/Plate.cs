namespace restaurant_domain
{
    public class Plate
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

        public int Id { get; set; }
        public string Name { get; private set; }
        //public decimal Price { get; private set; }
    }
}
