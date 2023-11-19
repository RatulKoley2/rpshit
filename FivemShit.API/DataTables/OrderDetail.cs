namespace FivemShit.API.DataTables
{
    public class OrderDetail
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int? MemberShipId { get; set; }
        public int? ScriptId { get; set; }
        public int? ScriptQuantity { get; set; }
        public double? ScriptsTotalPrice { get; set; }
        public double? MemberShipPrice { get; set; }
        public double DiscountPrice { get; set; }
        public double TotalPrice { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public Membership? Memberships { get; set; }
        public Script? Scripts { get; set; }
        public Order? Orders { get; set; }
    }
}
