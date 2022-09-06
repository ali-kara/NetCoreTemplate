using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EF.MainDB
{
    public class EfUserDal : EfEntityRepositoryBase<User, MainDBContext>, IUserDAL
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new MainDBContext())
            {
                //var result = from operationClaim in context.OperationClaims
                //             join userOperationClaim in context.UserOperationClaims
                //                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                //             where userOperationClaim.UserId == user.Id
                //             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                //return result.ToList();

                return null;
            }
        }
    }
}
