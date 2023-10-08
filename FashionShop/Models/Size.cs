using System.ComponentModel.DataAnnotations;

namespace FashionShop.Models
{
	public class Size
	{
		[Key]
		public int SizeId { get; set; }
		[Required]

		[StringLength(30)]
		public string? SizeName { get; set; }
	}
}
