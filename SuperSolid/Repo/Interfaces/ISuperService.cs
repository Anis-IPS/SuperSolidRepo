using SuperSolid.Models;

namespace SuperSolid.Repo.Interfaces
{
    // This is Super service interface.
    public interface ISuperService
    {
        SuperModel GetById(Guid id);
        List<SuperModel> GetAll();
    }
}
