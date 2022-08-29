namespace DataStructureAPI.Data.DAO.Repositories.Interfaces
{
    public interface IRepository
    {
        Task<BaseEntity> GetByNameAsync(string name);
    }
}
