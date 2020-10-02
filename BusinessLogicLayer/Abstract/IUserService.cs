using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Abstract
{
    public interface IUserService
    {
        IDataResult<IList<User>> GetList();
        IDataResult<User> GetById(Guid id);
        IDataResult<User> Add(User user);
        IDataResult<User> Update(User user);
        IResult Delete(User user);
        


    }
}
