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
    public class MonthManager:IMonthService
    {
        IMonthDal _monthDal;
        public MonthManager(IMonthDal MonthDal)
        {
            _monthDal = MonthDal;
        }

        public void TAdd(Month t)
        {
            _monthDal.Insert(t);
        }

        public void TDelete(Month t)
        {
            _monthDal.Delete(t);    
        }

        public Month TGetByID(int id)
        {
            return _monthDal.GetById(id);
        }

        public List<Month> TGetList()
        {
            return _monthDal.GetList();
        }

        public void TUpdate(Month t)
        {
             _monthDal.Update(t);
        }
    }
}
