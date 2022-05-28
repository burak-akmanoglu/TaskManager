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
    public class TaskImportanceManager:ITaskImportanceService
    {
        ITaskImportanceDal _taskImportanceDal;
        public TaskImportanceManager(ITaskImportanceDal TaskImportanceDal)
        {
            _taskImportanceDal = TaskImportanceDal;
        }

        public void TAdd(TaskImportance t)
        {
            _taskImportanceDal.Insert(t);
        }

        public void TDelete(TaskImportance t)
        {
            _taskImportanceDal.Delete(t);
        }

        public TaskImportance TGetByID(int id)
        {
            return _taskImportanceDal.GetById(id);
        }

        public List<TaskImportance> TGetList()
        {
            return _taskImportanceDal.GetList();
        }

        public void TUpdate(TaskImportance t)
        {
            _taskImportanceDal.Update(t);
        }
    }
}
