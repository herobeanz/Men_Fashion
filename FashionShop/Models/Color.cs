using System.ComponentModel.DataAnnotations;

namespace FashionShop.Models
{
	public class Color
	{
		[Key]
		public int ColorId { get; set; }
		[Required]

		[StringLength(30)]
		public string? ColorName { get; set; }
	}
}
