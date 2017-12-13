using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
	class NameMissing : ApplicationException
	{
		public string Message { get { return "Please Enter Name"; } }

		public NameMissing() : base("No Name Entered")
		{

		}
	}
}
