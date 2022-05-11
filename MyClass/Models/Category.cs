using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{   
    [Table("Categorys")]
    public class Category
    {   
        [Key]
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(255)]
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; }
        public string slug { get; set; }
        public int? ParentId { get; set; }
        public int? Orders { get; set; }
        [Required(ErrorMessage = "Mô tả sản phẩm không được để trống")]
        public string MetaDesc { get; set; }
        [Required(ErrorMessage = "Tên từ khóa không được để trống")]
        public string MetaKey { get; set; }

        public int? CreateBy { get; set; }
        public DateTime CreateAt { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        [Required]
        public int status { get; set; }
    }
}
