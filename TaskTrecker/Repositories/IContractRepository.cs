using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTrecker.Entities;

namespace TaskTrecker.Repositories
{
	public interface IContractRepository
	{
        IEnumerable<Contract> GetAll();
        void Add(Contract contract);
    }
}
