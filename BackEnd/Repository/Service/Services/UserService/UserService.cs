using Entity.Models.Users;
using Repository.Service.IService.IUserService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Service.Services.UserService
{
    public class UserService :  IUserService
    {
        private readonly ConstructionDbContext dbContext;

        public UserService(ConstructionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Add(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> AddAsync(User entity)
        {
            throw new System.NotImplementedException();
        }

        public bool AddRange(ICollection<User> entities)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public User GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetByIdAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public int GetCount()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GetCountAsync()
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(User entity)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveRange(ICollection<User> entities)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateRange(ICollection<User> entities)
        {
            throw new System.NotImplementedException();
        }
    }
}
