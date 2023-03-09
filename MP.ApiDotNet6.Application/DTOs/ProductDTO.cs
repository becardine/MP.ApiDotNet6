using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodeErp { get; set; }
        public decimal Price { get; set; }
    }
}
