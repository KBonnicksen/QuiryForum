using System.ComponentModel.DataAnnotations;

namespace QuiryForum.Models
{
    /// <summary>
    /// Represents a Category that questions can be sorted under.
    /// </summary>
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(80)]
        /// <summary>
        /// The name of the individual category.
        /// </summary>
        public string CategoryName { get; set; }
    }
}