using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    [Table("ProductsTags")]
    public class ProductsTags
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int TagID { get; set; }
    }
}
