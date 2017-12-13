using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
	class TooManyToppings : ApplicationException
	{
		public string Message { get { return "Too Many Toppings"; } }
		public TooManyToppings() : base("Too Many Toppings")
		{

		}
	}
}
