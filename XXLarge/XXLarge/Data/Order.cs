namespace XXLarge.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductsId { get; set; }
        public Product Products { get; set; }
        public string UsersId { get; set; }
        public User User { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderOn { get; set; } = DateTime.Now;
    } 
}
