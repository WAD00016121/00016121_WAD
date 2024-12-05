using System.ComponentModel.DataAnnotations;

namespace _16121_ExpenseManager.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }

        // 00016121
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

    }
}
