using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    [Table("Lessons")]
    public class Lesson : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }
        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }
    }
}
