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
    public class EfDayDal : GenericRepository<Day>, IDayDal
    {
        public List<Day> GetListDay()
        {
            using(var c= new Context())
            {
                return c.TblDay.Include(ba => ba.User).Include(ba=>ba.TaskImportance).Include(ba=>ba.TaskStatuse).ToList();
            }
          
        }
       
    }
}
