﻿using TheEye.Core.DataAccess.EntityFramework;
using TheEye.DataAccess.Abstract;
using TheEye.DataAccess.Concrete.EntityFramwork;
using TheEye.Entities.Concrete;

namespace TheEye.DataAccess.Concrete.EntityFramework
{
    public class EfSsnDal : EfEntityRepositoryBase<Ssn, TheEyeContext>, ISsnDal
    {
    }
}