using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Stationery
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được để trống tên.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Không được để trống mô tả.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Không được để trống ảnh đại diện.")]
        public string Img { get; set; }
        [Required(ErrorMessage = "Không được để trống số lượng.")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Không được để trống giá.")]
        public float Price { get; set; }

        public Category Category { get; set; }
        //public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}