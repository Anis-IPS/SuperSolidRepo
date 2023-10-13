using SuperSolid.Models;
using SuperSolid.Repo.Interfaces;

namespace SuperSolid.Repo.Services
{
    // This is Super Service class.
    public class SuperService : ISuperService
    {
        List<SuperModel> obj = new();
        public SuperService()
        {
            obj.Add(new SuperModel { Id = Guid.NewGuid(), Name = "Robin", Age = 23, Salary = 31000 });
            obj.Add(new SuperModel { Id = Guid.NewGuid(), Name = "Alexandra", Age = 34, Salary = 45000 });
            obj.Add(new SuperModel { Id = Guid.NewGuid(), Name = "Bob", Age = 32, Salary = 35000 });
        }
        public List<SuperModel> GetAll()
        {
            // Create dummy records
            List<SuperModel> obj = new();
            obj.Add(new SuperModel { Id = Guid.NewGuid(), Name = "Robin", Age = 23, Salary = 31000 });
            obj.Add(new SuperModel { Id = Guid.NewGuid(), Name = "Alexandra", Age = 34, Salary = 45000 });
            obj.Add(new SuperModel { Id = Guid.NewGuid(), Name = "Bob", Age = 32, Salary = 35000 });

            return obj;
        }

        public SuperModel GetById(Guid id)
        {
            var result = obj.Where(x => x.Id == id).FirstOrDefault();

            return result ?? new();
        }
    }
}
