namespace Enum_Composicao
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

    }
}