using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Không được để trống tên.")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Không được để trống mô tả.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Không được để trống ảnh đại diện.")]
        public string Img { get; set; }

        public ICollection<Stationery> Stationeries { get; set; }
    }
}