namespace FivemShit.API.DataTables
{
    public class Membership
    {
        public Membership() 
        { 
            Users = new HashSet<User>();
            Carts = new HashSet<Cart>();
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int MemberShipId { get; set; }
        public required string MembershipName { get; set;}
        public double MemberShipPrice { get; set; }
        public string? MembershipDescription { get; set; }
        public string? Remarks { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<User>? Users { get; set;}
        public ICollection<Cart>? Carts { get; set;}
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
