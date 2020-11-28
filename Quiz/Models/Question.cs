using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    [Table("Questions")]
    public class Question : BaseEntity
    {
        public int Id { get; set; }
        [ForeignKey("TestId")]
        public virtual Test Test { get; set; }
        public string Name { get; set; }
        public string CorrectAnswer { get; set; }

    }
}
