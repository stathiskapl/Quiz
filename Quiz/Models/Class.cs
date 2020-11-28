using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    [Table("Classes")]
    public class Class : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }
    }
}
