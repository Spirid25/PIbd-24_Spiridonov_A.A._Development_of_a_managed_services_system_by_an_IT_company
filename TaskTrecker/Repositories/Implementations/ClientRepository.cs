using TaskTrecker.Entities;

namespace TaskTrecker.Repositories.Implementations
{
    internal class ClientRepository : IClientRepository
    {
        public void Add(Client client) { }

        public void Delete(int id) { }

        public Client GetById(int id)
        {
            return Client.CreateEntity(0, string.Empty, string.Empty);
        }

        public IEnumerable<Client> GetAll()
        {
            return [];
        }

        public void Update(Client client) { }
    }
}