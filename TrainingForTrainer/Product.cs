namespace TrainingForTrainer
{
    public class Product : ISoftware
    {
        private readonly string name;
        private readonly double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name()
        {
            return name;
        }

        public double TotalPrice()
        {
            return price;
        }
    }
}