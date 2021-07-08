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

        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }

    public class Restaurante
    {
        public Restaurante(string nome, string adress)
        {
            Nome = nome;
            Adress = adress;
        }
        
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
        public string Adress { get; private set; }
    }
    
    public class Menu
        public Menu(int id)
        public Restaurant Restaurant { get; set; }
    public List<Plate> Plates { get; set; }
}
}
