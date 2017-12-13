using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermConsole
{
	public abstract class Item
	{
		private System.Guid _id;

		public System.Guid Id { get; }

		public string Name
		{
			get;
		}
		public double Weight
		{
			get;
		}
		public InventorySlotId Slot
		{
			get;
		}
		public bool isNatural
		{
			get;
		}


		//public int CompareTo(Object obj)
		//{
		//	return int;
		//}

		//public bool Equals(Object obj)
		//{
		//	return bool;
		//}

		//public int GetHashCode()
		//{
		//	return int;
		//}

		//public string ToString()
		//{
		//	return string;
		//}
	}
}
