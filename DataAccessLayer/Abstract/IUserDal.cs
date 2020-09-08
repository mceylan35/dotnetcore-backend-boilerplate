using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {

    }
}
