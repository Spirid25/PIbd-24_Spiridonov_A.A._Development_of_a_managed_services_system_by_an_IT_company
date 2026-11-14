using TaskTrecker.Entities;

namespace TaskTrecker.Repositories.Implementations
{
    internal class ContractRepository : IContractRepository
    {
        public void Add(Contract contract) { }

        public IEnumerable<Contract> GetAll()
        {
            return [];
        }
    }
}