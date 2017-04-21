using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace gummi_bear_kingdom.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Origin { get; set; }
    }
}
