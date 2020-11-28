using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    [Table("Tests")]
    public class Test : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("LessonId")]
        public virtual Lesson Lesson { get; set; }
    }
}
