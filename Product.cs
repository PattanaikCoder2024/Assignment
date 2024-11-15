using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachineTestCRUD.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        // Foreign key for Category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}