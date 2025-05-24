﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BTL_nhom11_marketPC.Models
{
    public class RAM
    {
        [Key]
        public string MaRAM { get; set; }

        [Required]
        public string TenRAM { get; set; }
        public int Bus { get; set; }
        public int Dungluong { get; set; }

        public string Mota { get; set; }

        [ForeignKey("Manufacturer")]
        public string MaHSX { get; set; } // Khóa ngoại trực tiếp từ CSDL
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
