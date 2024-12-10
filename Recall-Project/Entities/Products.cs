using System.ComponentModel.DataAnnotations;

namespace Recall_Project.Entities
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Product_Cost { get; set; }
        public string Product_Color { get; set; }
    }
}
