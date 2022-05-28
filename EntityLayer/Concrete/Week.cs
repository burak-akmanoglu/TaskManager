using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Week
    {
        [Key]
        public int WeekID { get; set; }
        public int WeekTime { get; set; }
        public string WeekTaskContent { get; set; }
        public string WeekTaskFinishTime { get; set; }

    }
}
