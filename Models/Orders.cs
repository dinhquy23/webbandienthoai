using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Create { get; set; }
        public int Status { get; set; }
        public double Price { get; set; }
    }
}
