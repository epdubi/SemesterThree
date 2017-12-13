using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
	class TooManyFlavors : ApplicationException
	{
		public string Message { get { return "Too Many Flavors"; } }
		public TooManyFlavors() : base("Too Many Toppings")
		{

		}
	}
}
