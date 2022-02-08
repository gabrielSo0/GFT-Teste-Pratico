namespace loja.src.Models
{
    public abstract class Books : Product
    {
        public string Author { get; set; }
        public string Theme { get; set; }
        public int QtPayment { get; set; }

        public Books()
        {
            
        }
        public Books(string author, string theme, int qtPayment, string name, double price, int quantity) : base(name, price, quantity)
        {
            
        }

    }
}