using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Day
    {
        [Key]
        public int DayId { get; set; }
        public int DayTime { get; set; }
        public string DayTaskContent { get; set; }
        public string DayTaskFinishTime { get; set; }

    }
}
