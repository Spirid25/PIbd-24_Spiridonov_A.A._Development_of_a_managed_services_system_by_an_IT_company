using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTrecker.Enums
{
	[Flags]
	public enum ServiceType
	{
		None = 0,
		Development = 1,
		Support = 2,
		Testing = 4
	}
}
