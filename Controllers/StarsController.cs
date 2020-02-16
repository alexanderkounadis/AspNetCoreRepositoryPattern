using AspNetCoreRepositoryPattern.Data.EFCore;
using AspNetCoreRepositoryPattern.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : MyMDBController<Star, EFCoreStarRepository>
    {
        public StarsController(EFCoreStarRepository repository) : base(repository)
        {
        }
    }
}
