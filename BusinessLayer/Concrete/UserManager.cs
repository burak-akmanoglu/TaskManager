﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal UserDal)
        {
            _userDal = UserDal;
        }

        public List<Day> GetListDayWithUser()
        {
            throw new NotImplementedException();
        }

        public void TAdd(User t)
        {
            _userDal.Insert(t);
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public User TGetByID(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> TGetList()
        {
            return _userDal.GetList();
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
