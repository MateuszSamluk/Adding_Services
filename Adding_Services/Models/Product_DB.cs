using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adding_Services.Models
{
    public class Product_DB
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Maker { get; set; }

        [Required]
        [MaxLength(300)]
        public string Image { get; set; }
        [Required]
        [MaxLength(200)]
        public string Url { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
