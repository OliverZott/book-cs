using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WorkingWithEEFCore
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        // define a navigation property for related rows
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            // to enable developers to add products to a Category we must
            // initiaize the navigation property to an empty collection.
            this.Products = new HashSet<Product>();
        }




    }
}