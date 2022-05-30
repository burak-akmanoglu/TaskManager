using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BusinessLayer.Concrete
{
    public class DayManager:IDayService
    {
        IDayDal _dayDal;
        public DayManager(IDayDal DayDal)
        {
            _dayDal = DayDal;
        }

        public void TAdd(Day t)
        {
            _dayDal.Insert(t);
        }

        public void TDelete(Day t)
        {
            _dayDal.Delete(t);
        }

        public Day TGetByID(int id)
        {
            return _dayDal.GetById(id);
        }

        public List<Day> TGetList()
        {
          
            return _dayDal.GetList();
        }

        public void TUpdate(Day t)
        {
            _dayDal.Update(t);
        }
        

        public List<Day> GetListDay()
        {
            return _dayDal.GetListDay();
        }
    }
}
