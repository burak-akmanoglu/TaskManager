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
 


        [ForeignKey("User")]
        public int? UserID { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("TaskImportance")]
        public int? TaskImportanceID { get; set; }
        public virtual TaskImportance TaskImportance { get; set; }

        [ForeignKey("TaskStatuse")]
        public int? TaskStatuseID { get; set; }
        public virtual TaskStatuse TaskStatuse { get; set; }

    }
}
