using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookstoreWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category name")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100")]
        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }
    }
}
