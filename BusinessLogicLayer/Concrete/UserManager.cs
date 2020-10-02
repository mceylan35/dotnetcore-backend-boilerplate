using BusinessLogicLayer.Abstract;
using Core.Utilities.Results;
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
        public IDataResult<User> Add(User user)
        {
            return new SuccessDataResult<User>(_userDal.Add(user));
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult("Ürün Silindi");
        }

        public IDataResult<User> GetById(Guid id)
        {
            return new SuccessDataResult<User>(_userDal.GetById(id));
        }

        public IDataResult<IList<User>> GetList()
        {
            return new SuccessDataResult<IList<User>>(_userDal.GetAll());
        }

        public IDataResult<User> Update(User user)
        {
            return new SuccessDataResult<User>(_userDal.Update(user));
        }
    }
}
