using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
	public class Order
	{
		private string _name;
		private Sundae _sundae;
		private Soda _soda;

		public string Name { get { return _name; } }
		public Sundae Sundae { get { return _sundae; } }
		public Soda Soda { get { return _soda; } }
		public double Price
		{
			get
			{
				double total = 0;
				if (_sundae != null)
				{
					total += _sundae.Price;
				}
				if (_soda != null)
				{
					total += _soda.Price;
				}

				return total;
			}
		}

		public Order(string name, bool hasSundae, bool hasSoda)
		{
			if (name == "")
			{
				throw new NameMissing();
			}
			if (hasSundae == false && hasSoda == false)
			{
				throw new NoFood();
			}
			_name = name;

			if (hasSundae)
			{
				_sundae = new Sundae();
			}
			if (hasSoda)
			{
				_soda = new Soda();
			}
		}

		public override string ToString()
		{
			string order = _name + "\r\n---------------------\r\n";
			if (_sundae != null)
			{
				order += _sundae.ToString() + "\r\n";
			}
			if (_soda != null)
			{
				order += _soda.ToString() + "\r\n";
			}
			return order;
		}

	}
}
	
