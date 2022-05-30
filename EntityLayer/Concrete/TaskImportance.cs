using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TaskImportance
    {
        [Key]
        public int TaskImportanceID { get; set; }
        public string TaskImportanceName { get; set; }

        public List<Day> Day { get; set; }
        public List<Week> Week { get; set; }
        public List<Month> Month { get; set; }


    }
}
