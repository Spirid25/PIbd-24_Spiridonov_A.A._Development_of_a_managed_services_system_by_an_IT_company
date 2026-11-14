using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTrecker.Entities
{
	public class Client
	{
		public int Id { get; private set; }
		public string Name { get; private set; } = string.Empty;
		public string Inn { get; private set; } = string.Empty;

		public static Client CreateEntity(int id, string name, string
		inn)
		{
			return new Client
			{
				Id = id,
				Name = name ?? string.Empty,
				Inn = inn ?? string.Empty,
			};
		}
	}
}
