using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShopProject.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Category name is required")]
        [MaxLength(45, ErrorMessage = "Category Name is limited to 45 characters only")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}