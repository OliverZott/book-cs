using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace WorkingWithEEFCore
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; }  // property name != field name

        [Column("UnitInStock")]
        public short? Stock { get; set; }

        public bool Discontinued { get; set; }

        // following two define the foreign key relationship
        // to the categories table
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}