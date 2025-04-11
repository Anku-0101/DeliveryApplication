namespace FoodDeliveryApplication.Models
{
    public class Agent
    {
        public int Id { get; set; }
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public bool Busy { get; set; } = false;
        public int? CurrentOrderId { get; set; }
    }
}
