namespace Enum_Composicao
{
    public class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();



        public void addItem(OrderItem item)
        {

        }

        public void removeItem(OrderItem item)
        {

        }

        public double total()
        {
            return 0;
        }
    }
}