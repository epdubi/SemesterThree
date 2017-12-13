using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
	public class Sundae
	{
		public const double BASE_PRICE = 4.50;
		public const double TOPPING_PRICE = .50;
		private SundaeTopping[] _toppings = new SundaeTopping[2];

		private int _toppingCount = 0;
		private double _price;

		public int ToppingCount { get { return _toppingCount; } }
		public double Price { get { return _price; } }

		public Sundae()
		{
			_price = BASE_PRICE;
		}

		public void AddTopping(SundaeTopping t)
		{
			if (_toppingCount > 1)
			{
				throw new TooManyToppings();
			}
			_toppings[_toppingCount] = t;
			_toppingCount++;
			_price += TOPPING_PRICE;
		}

		public override string ToString()
		{
			string toppings = "";
			for (int i = 0; i < _toppingCount; i++)
			{
				toppings += string.Format("{0} ", _toppings[i]);
			}

			if (toppings == "")
			{
				toppings = "NONE";
			}

			return string.Format("Sundae price - {0}- {1:C}", toppings, _price);
		}
	}
}
