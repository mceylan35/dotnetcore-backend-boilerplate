using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Abstract
{
    public interface IUserService
    {
        IList<User> GetList();
        User GetById(Guid id);
        User Add(User user);
        User Update(User user);
        bool Delete(User user);
        


    }
}
