namespace restaurant_domain
{
    public class Plate
    {
        public Plate(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
}
