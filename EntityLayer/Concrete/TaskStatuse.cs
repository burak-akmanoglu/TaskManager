using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TaskStatuse
    {
        [Key]
        public int TaskStatuseID { get; set; }
        public string TaskStatuseName { get; set; }


    }
}
