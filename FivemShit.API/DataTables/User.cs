namespace FivemShit.API.DataTables
{
    public class User
    {
        public User() 
        {
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int MemberId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? DiscordUserName { get; set; }
        public string? FivemUserName { get; set; }
        public string? ScriptsPurchased { get; set; }
        public bool IsMember { get; set; }
        public bool IsWhiteListed { get; set; }
        public bool IsActive { get; set; }
        public bool IsBanned { get; set; }
        public DateTime CreatedAt { get; set; }
        public Role? Roles { get; set; }
        public Membership? MemberShips { get; set; }
        public ICollection<Cart>? Carts { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
