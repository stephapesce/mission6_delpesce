using System.ComponentModel.DataAnnotations;

namespace mission6_delpesce.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
