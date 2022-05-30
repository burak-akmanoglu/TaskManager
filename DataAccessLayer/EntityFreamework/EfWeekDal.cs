using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFreamework
{
    public class EfWeekDal:GenericRepository<Week>,IWeekDal
    {
        public List<Week> GetListWeek()
        {
            using (var c = new Context())
            {
                return c.TblWeek.Include(ba => ba.User).Include(ba => ba.TaskImportance).Include(ba => ba.TaskStatuse).ToList();
            }

        }
    }
}
