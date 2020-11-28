using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class BaseEntity
    {
        public DateTime? CreatedOnDateTime { get; set; }
        public DateTime? UpdatedOnDateTime { get; set; }
    }
}
