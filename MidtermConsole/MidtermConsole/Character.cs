using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermConsole
{
	class Character
	{
		protected StoredItems _bag;
		protected EquippedItems _Equipped;
		protected string _name;
		protected int _attackPower;
		protected int _currentHealth;
		protected bool _dead;

		public StoredItems Bag { get; }
		public EquippedItems Equipped { get; }
		public string Name {
			get { return _name; }
			set { _name = value; }
				}
		public int AttackPower {
			get { return _attackPower; }
			set { _attackPower = value; }
		}
		public int CurrentHealth {
			get { return _currentHealth; }
			set { _currentHealth = value; }
		}
		public bool IsDead
		{
			get { return _dead; }
			set { _dead = value; }
		}



		//public double CalcTotalWeight()
		//{
		//	return double;
		//}

		//public int CalcTotalAttackValue()
		//{
		//	return int;
		//}

		//public int CalcTotalDefenseValue()
		//{
		//	return int;
		//}

		//public void TakeDamage(int damage)
		//{

		//}

		//public void Pickup(Item item)
		//{

		//}

		//public void UnEquipAll()
		//{

		//}
	}
}
