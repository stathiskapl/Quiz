using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    [Table("Results")]
    public class Result
    {
        public int Id { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
        [ForeignKey("AnswerId")]
        public virtual Answer Answer { get; set; }
    }
}
