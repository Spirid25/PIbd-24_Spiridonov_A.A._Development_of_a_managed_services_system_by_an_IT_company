using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTrecker.Entities;

namespace TaskTrecker.Repositories
{
	public interface IClientRepository
	{
        IEnumerable<Client> GetAll();
        Client GetById(int id);
        void Add(Client client);
        void Update(Client client);
        void Delete(int id);
    }
}
