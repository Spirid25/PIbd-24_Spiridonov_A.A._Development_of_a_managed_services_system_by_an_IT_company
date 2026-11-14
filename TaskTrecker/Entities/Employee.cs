using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTrecker.Entities
{
	public class Employee
	{
		public int Id { get; private set; }
		public string FirstName { get; private set; } = string.Empty;
		public string LastName { get; private set; } = string.Empty;

		public static Employee CreateEntity(int id, string firstname, string
		lastname)
		{
			return new Employee
			{
				Id = id,
				FirstName = firstname ?? string.Empty,
				LastName = lastname ?? string.Empty,
			};
		}
	}
}
