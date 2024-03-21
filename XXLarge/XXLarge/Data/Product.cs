using System.ComponentModel.DataAnnotations.Schema;

namespace XXLarge.Data
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int MaterialsId { get; set; }
        public Material Materials {  get; set; }
        public string ImageURL { get; set; }
        [Column (TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
