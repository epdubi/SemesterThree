using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermConsole
{
	class StoredItems
	{
		int _count;
		string[] _items = new string[10];
		int[] _attackPower = new int[10];

		public string[] Items {
			get { return _items; }
			set { _items = value; }
		}

		public int[] AttackPower
		{
			get { return _attackPower; }
			set { _attackPower = value; }
		}

		public int Count { get; }
		public int Capacity { get; }

		public StoredItems(string item1, int atk1, string item2, int atk2, string item3, int atk3, string item4, int atk4, string item5, int atk5, string item6, int atk6, string item7, int atk7, string item8, int atk8, string item9, int atk9, string item10, int atk10)
		{
			_items[0] = item1;
			AttackPower[0] = atk1;
			_items[1] = item2;
			AttackPower[1] = atk2;
			_items[2] = item3;
			AttackPower[2] = atk3;
			_items[3] = item4;
			AttackPower[3] = atk4;
			_items[4] = item5;
			AttackPower[4] = atk5;
			_items[5] = item6;
			AttackPower[5] = atk6;
			_items[6] = item7;
			AttackPower[6] = atk7;
			_items[7] = item8;
			AttackPower[7] = atk8;
			_items[8] = item9;
			AttackPower[8] = atk9;
			_items[9] = item10;
			AttackPower[9] = atk10;

		}

		//public Item GetItem(int index)
		//{
		//	return Item;
		//}

		//public Item SetItem(int index, Item item)
		//{
		//	return item;
		//}

		//public void AddItem(Item item)
		//{

		//}

		//public void RemoveItem(Item item)
		//{

		//}

		//public double CalcTotalWeight()
		//{
		//	return double;
		//}
	}
}
