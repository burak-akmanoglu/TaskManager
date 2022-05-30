using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WeekManager:IWeekService
    {
        IWeekDal _weekDal;
        public WeekManager(IWeekDal WeekDal)
        {
            _weekDal = WeekDal;
        }

      

        public List<Week> GetListWeek()
        {
            return _weekDal.GetListWeek();
        }

        public void TAdd(Week t)
        {
            _weekDal.Insert(t);
        }

        public void TDelete(Week t)
        {
            _weekDal.Delete(t);
        }

        public Week TGetByID(int id)
        {
           return _weekDal.GetById(id);
        }

        public List<Week> TGetList()
        {
            return _weekDal.GetList();
        }

        public void TUpdate(Week t)
        {
            _weekDal.Update(t);
        }
    }
}
