using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FashionShop.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }

		[Required]
		[StringLength(100)]
		public string? ProductName { get; set; }

		[Required]
		public int ProductQuantity { get; set; }

		[Required]
		[StringLength(10000)]
		public string? ProductDescription { get; set; }
		[Required]
		[Column(TypeName = "decimal(8,2)")]
		public decimal ProductPrice { get; set; }
		[Required]
		[Column(TypeName = "decimal(2,2)")]
		public decimal ProductDiscount { get; set; }
		[Required]
		[StringLength(100)]
		public string? ProductPhoto { get; set; }

		[ForeignKey("Category")]
		public int CategoryId { get; set; }
		public Category? Category { get; set; }

		[ForeignKey("Size")]
		public int SizeId { get; set; }
		public Size? Size { get; set; }

		[ForeignKey("Color")]
		public int ColorId { get; set; }
		public Color? Color { get; set; }
		public bool IsTrandy { get; set; }
		public bool IsArrived { get; set; }

	}
}
