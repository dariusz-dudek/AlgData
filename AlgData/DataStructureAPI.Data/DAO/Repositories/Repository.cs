namespace DataStructureAPI.Data.DAO.Repositories
{
    public class Repository : IRepository
    {
        private readonly DataStructureContext _context;

        public Repository(DataStructureContext context)
        {
            _context = context;
        }

        public async Task<BaseEntity> GetByNameAsync(string name)
            => await _context.BaseEntities.FirstOrDefaultAsync(be => be.Name == name);
    }
}
