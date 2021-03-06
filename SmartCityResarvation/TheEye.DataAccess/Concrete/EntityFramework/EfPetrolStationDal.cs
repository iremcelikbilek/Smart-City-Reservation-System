﻿using TheEye.Core.DataAccess.EntityFramework;
using TheEye.DataAccess.Abstract;
using TheEye.Entities.Concrete;

namespace TheEye.DataAccess.Concrete.EntityFramework
{
    public class EfPetrolStationDal : EfEntityRepositoryBase<PetrolStation, TheEyeContext>, IPetrolStationDal
    {
    }
}
