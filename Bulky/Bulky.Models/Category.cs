using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        //[Key] // Primary key DataAnotation.. automaticly added if the prop is Id
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")] //Data Anotation to add space in the html
        public string Name { get; set; }
        [DisplayName("Display Order")] //Data Anotation to add space in the html
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}   
