namespace FivemShit.API.DataTables
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string? OrderNo { get; set; }
        public string? OrderStatus { get; set; }
        public double OrderTotal { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public User? Users { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
