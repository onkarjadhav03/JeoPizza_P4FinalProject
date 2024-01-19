namespace JoePizza.Models
{
    public class OrderView
    {
        public Pizza SelectedPizza { get; set; }
        public int Quantity { get; set; }

        public float TotalPrice
        {
            get { return SelectedPizza.Price * Quantity; }
        }
    }
}
