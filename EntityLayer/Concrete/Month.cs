using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Month
    {
        [Key]
        public int MonthID { get; set; }
        public int MonthTime { get; set; }
        public string MonthTaskContent { get; set; }
        public string MonthTaskFinishTime { get; set; }

    }
}
