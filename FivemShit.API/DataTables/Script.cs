namespace FivemShit.API.DataTables
{
    public class Script
    {
        public Script()
        {
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int ScriptId { get; set; }
        public required string ScriptName { get; set; }
        public double ScriptPrice { get; set; }
        public string? ScriptDescription { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public ICollection<Cart>? Carts { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
