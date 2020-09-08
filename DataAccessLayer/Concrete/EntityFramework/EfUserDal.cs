using Core.DataAccess;
using Core.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework.Contexts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,EfDatabaseContext>,IUserDal
    {

    }
}
