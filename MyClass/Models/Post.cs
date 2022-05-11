using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyClass.Models
{   
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TopicId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Slug { get; set; }
        [Required]
        public string Detail { get; set; }
        [Required]
        public string MetaKey { get; set; }
        [Required]
        public string Metadesc { get; set; }
        public string Img { get; set; }
        public DateTime? Create_At { get; set; }
        public int Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Update_By { get; set; }
        public DateTime? Update_At { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
