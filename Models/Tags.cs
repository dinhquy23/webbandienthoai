using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    [Table("Tags")]
    public class Tags
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
