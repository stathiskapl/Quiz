using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    [Table("Answers")]
    public class Answer
    {
        public int Id { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
        public string Name { get; set; }
    }
}
