﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyClass.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public int ParentId { get; set; }
        public int Orders { get; set; }
        [Required]
        public string MetaKey { get; set; }
        [Required]
        public string Metadesc { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Update_By { get; set; }
        public DateTime? Update_At { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
