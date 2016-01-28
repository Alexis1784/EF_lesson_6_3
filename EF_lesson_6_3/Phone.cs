using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_3
{
    public class Phone
    {
        [Key]
        public int Ident { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [NotMapped]
        public int Discount { get; set; }
    }
}
