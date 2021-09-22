using System;
using System.ComponentModel.DataAnnotations;

namespace SR6.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required(ErrorMessage ="Category Name field is required!")]
        [Display(Name ="Category Name")]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(100)]
        public string Descrition { get; set; }
    }
}
