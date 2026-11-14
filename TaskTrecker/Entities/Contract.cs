using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTrecker.Enums;
namespace TaskTrecker.Entities;

public class Contract
{
	public int Id { get; private set; }
	public int ClientId { get; private set; }
	public int EmployeeId { get; private set; }
	public ContractStatus Status { get; private set; }
	public static Contract CreateEntity(int id, int clientId, int
	employeeId, ContractStatus status)
	{
		return new Contract
		{
			Id = id,
			ClientId = clientId,
			EmployeeId = employeeId,
			Status = status,
		};
	}
}
