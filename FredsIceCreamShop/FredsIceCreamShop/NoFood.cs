using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
	class NoFood : ApplicationException
	{
		public string Message { get { return "Please Buy Food"; } }
		public NoFood() : base("No Food Entered")
		{

		}
	}
}
