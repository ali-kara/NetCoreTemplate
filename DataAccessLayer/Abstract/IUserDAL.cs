﻿using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserDAL : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);

    }
}
