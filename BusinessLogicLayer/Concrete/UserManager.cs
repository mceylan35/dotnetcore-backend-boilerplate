using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userdal)
        {
            _userDal = userdal;
        }
        public User Add(User user)
        {
            return _userDal.Add(user);
        }

        public bool Delete(User user)
        {
            return _userDal.Delete(user);
        }

        public User GetById(Guid id)
        {
            return _userDal.GetById(id);
        }

        public IList<User> GetList()
        {
            return _userDal.GetAll() ;
        }

        public User Update(User user)
        {
            return _userDal.Update(user);
        }
    }
}
