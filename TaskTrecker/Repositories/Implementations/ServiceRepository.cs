using TaskTrecker.Entities;
using TaskTrecker.Enums;

namespace TaskTrecker.Repositories.Implementations
{
    internal class ServiceRepository : IServiceRepository
    {
        public void Add(Service service)
        { 
        }

        public void Delete(int id) 
        { 
        }

        public Service GetById(int id)
        {
            return Service.CreateEntity(0, 0, ServiceType.None);
        }

        public IEnumerable<Service> GetAll()
        {
            return [];
        }

        public void Update(Service service) 
        { 
        }
    }
}