using AspNetCoreRepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreRepositoryPattern.Data.EFCore
{
    public class EFCoreStarRepository : EfCoreRepository<Star, MyMDBContext>
    {
        public EFCoreStarRepository(MyMDBContext context) : base(context)
        {
        }
    }
}
