using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
	public class Soda
	{
		public const double BASE_PRICE = 1.75;
		public const double FLAVOR_PRICE = 0.15;

		private SodaFlavor _flavor;

		private double _price;

		public SodaFlavor Flavor { get { return _flavor; } }
		public double Price { get { return _price; } }

		public Soda()
		{
			_price = BASE_PRICE;
		}

		public void AddFlavor(SodaFlavor f)
		{
			if (_flavor == SodaFlavor.NONE)
			{
				_flavor = f;
				_price += FLAVOR_PRICE;
			}
			else
			{
				throw new TooManyFlavors();
			}
		}

		public override string ToString()
		{
			return string.Format("Soda Price - {0}, Flavor - {1}", _price, _flavor);
		}
	}
}
