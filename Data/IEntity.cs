using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreRepositoryPattern.Data
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
