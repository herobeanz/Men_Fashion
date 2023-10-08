using System.ComponentModel.DataAnnotations;

namespace FashionShop.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		[Required]
		[StringLength(100)]
		public string? CategoryName { get; set; }
		[Required]
		[StringLength(100)]
		public string? CategoryPhoto { get; set; }
		[Required]
		[StringLength(10000)]
		public string? CategoryDescription { get; set; }
		[Required]
		public int CategoryOrder { get; set; }

	}
}
