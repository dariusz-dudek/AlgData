using DataStructureAPI.Data.DAO.Repositories.Interfaces;
using DataStructureAPI.Data.Entries;

namespace DataStructureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStructureController : ControllerBase
    {
        private readonly IRepository _repository;

        public DataStructureController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("{name}")]
        public async Task<ActionResult<BaseEntity>> GetByNameAsync(string name)
            => Ok(await _repository.GetByNameAsync(name));
    }
}
