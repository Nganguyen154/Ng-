﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BTL_nhom11_marketPC.Models
{
    public class CPU
    {
        [Key]
        public string MaCPU { get; set; }

        [Required]
        public string TenCPU { get; set; }
        public string Tocdo { get; set; }
        public string Socket { get; set; }

        public string Mota { get; set; }

        [ForeignKey("Manufacturer")]
        public string MaHSX { get; set; } // Khóa ngoại trực tiếp từ CSDL
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
