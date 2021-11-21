using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPractice.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Не определен";
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
