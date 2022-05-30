using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMonthService:IGenericService<Month>
    {

        List<Month> GetListMonth();
    }
}
