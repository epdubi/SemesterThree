using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MidtermConsole
{
	class Program
	{
		static void Main(string[] args)
		{

			//Welcome screen and naming character
			int battleCount = 1;
			Console.WriteLine("Welcome to my game!");
			Console.WriteLine("Please enter your character name below");
			Character Player = new Character();
			Player.Name = Console.ReadLine().ToUpper();
			Player.AttackPower = 0;
			Player.IsDead = false;
			
			StoredItems startInventory = new StoredItems("Dagger = 10attack", 10, "ChestPlate = 10attack", 10, "LegPlate = 10attack", 10, "Helmet = 10attack", 10, "", 10, "", 15, "", 15, "", 20, "", 25, "", 30 );
		
			
			Console.Clear();
			


			//INVENTORY SCREEN
			Console.WriteLine("Welcome, " + Player.Name);
			for (; ; )
			{
				//Access Inventory
				Console.WriteLine("Enter 1 to view " + Player.Name + "s" + " Inventory. Enter 2 to battle enemies. Enter 3 to exit game");
				string playerMenu = Console.ReadLine();

				if (playerMenu == "1")
				{

					//Shows 4 Starting Items 
					Console.Clear();
					Console.WriteLine(Player.Name + " Inventory");
					Console.WriteLine("--------------------");
					
					for (int i = 0; i < 10; i++)
					{
						
						Console.WriteLine(startInventory.Items[i].ToUpper());
					}
					Console.WriteLine("To equppied items type equip. To unequip items type unequip. Or type no to return to character menu");
					string equippedItems = Console.ReadLine().ToUpper();
					if (equippedItems == "EQUIP")
					{
						for (; ; )
						{
							Console.WriteLine("Enter items you want to equip or enter done when finished");
							string equip = Console.ReadLine().ToUpper();
							if (equip == "DAGGER")
							{
								Player.AttackPower += startInventory.AttackPower[0];
								Console.WriteLine("Player attack =" + Player.AttackPower);
								
							}
							if (equip == "CHESTPLATE")
							{
								Player.AttackPower += startInventory.AttackPower[1];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "LEGPLATE")
							{
								Player.AttackPower += startInventory.AttackPower[2];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "HELMET")
							{
								Player.AttackPower += startInventory.AttackPower[3];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "VAMBRACES")
							{
								Player.AttackPower += startInventory.AttackPower[4];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "WAR BOOTS")
							{
								Player.AttackPower += startInventory.AttackPower[5];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "WAR GLOVES")
							{
								Player.AttackPower += startInventory.AttackPower[6];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "WIZARD POTION")
							{
								Console.WriteLine("Potion Equipped");
							}
							if (equip == "WAR NECKLACE")
							{
								Player.AttackPower += startInventory.AttackPower[8];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "WAR RING")
							{
								Player.AttackPower += startInventory.AttackPower[9];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "DONE")
							{
								Console.Clear();
								break;
							}
						}
					}
					if (equippedItems == "UNEQUIP")
					{
						for (; ; )
						{
							Console.WriteLine("Enter items you want to unequip or enter done when finished");
							string equip = Console.ReadLine().ToUpper();
							if (equip == "DAGGER")
							{
								Player.AttackPower -= startInventory.AttackPower[0];
								Console.WriteLine("Player attack =" + Player.AttackPower);

							}
							if (equip == "CHESTPLATE")
							{
								Player.AttackPower -= startInventory.AttackPower[1];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "LEGPLATE")
							{
								Player.AttackPower -= startInventory.AttackPower[2];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "HELMET")
							{
								Player.AttackPower -= startInventory.AttackPower[3];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "VAMBRACES")
							{
								Player.AttackPower -= startInventory.AttackPower[4];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "WAR BOOTS")
							{
								Player.AttackPower -= startInventory.AttackPower[5];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "WAR GLOVES")
							{
								Player.AttackPower -= startInventory.AttackPower[6];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "WIZARD POTION")
							{
								Console.WriteLine("Potion Equipped");
							}
							if (equip == "WAR NECKLACE")
							{
								Player.AttackPower -= startInventory.AttackPower[7];
								Console.WriteLine("Player attack =" + Player.AttackPower);
							}
							if (equip == "DONE")
							{
								Console.Clear();
								break;
							}
						}
					}
					else
					{
						Console.Clear();
					}
					
				} // Inventory
				
				if (playerMenu == "2")
				{
					
					battleCount++;
						if (battleCount == 2)
						{
							Console.Clear();
							Character rat = new Character();
							rat.AttackPower = 5;
							rat.CurrentHealth = 220;
							Player.CurrentHealth = 100;
						
						Console.WriteLine("You have approched a rat!");
							Console.WriteLine("PLAYER ATTACK: " + Player.AttackPower + " HEALTH: " + Player.CurrentHealth);
							Console.WriteLine("RAT ATTACK: " + rat.AttackPower + " HEALTH: " + rat.CurrentHealth);
							Console.WriteLine("-----------------------------------------------");
							for (; ; )
							{
							if (Player.CurrentHealth < 0)
							{
								Console.Clear();
								Console.WriteLine("You died! Better luck next time..");
								Player.IsDead = true;
								break;
							}
							if (rat.CurrentHealth < 0)
							{
								Console.Clear();
								battleCount++;
								startInventory.Items[4] = "Vambraces = 10ATTACK";
								Console.WriteLine("The Rat is dead! Let's see new loot");
								Console.WriteLine("------------------------------");
								break;
							}
							Console.WriteLine("Enter 1 to attack");
								string attack = Console.ReadLine();
								if (attack == "1")
								{
									if (rat.CurrentHealth > 0)
									{
									Random random = new Random();
									int playerRandom = random.Next(4);
									Random random2 = new Random();
									int enemyRandom = random2.Next(3);

									//Console.WriteLine("PlayerRan = " + playerRandom + " enemyRan = " + enemyRandom );
									Console.WriteLine("RAT HEALTH: " + (rat.CurrentHealth -= (Player.AttackPower * playerRandom)));
									Console.WriteLine(Player.Name + " HEALTH: " + (Player.CurrentHealth -= (rat.AttackPower * enemyRandom)));

								}
								
									else
									{
									Console.Clear();
									battleCount++;
									startInventory.Items[4] = "Vambraces = 10ATTACK";
									Console.WriteLine("The Rat is dead! Let's see new loot");
									Console.WriteLine("------------------------------");
									break;
								}

								}
								else
								{
									Console.WriteLine("Please enter valid entry");
								}
							}
						} // Rat Battle

					if (battleCount == 4)
					{
						Console.Clear();
						Character Dog = new Character();
						Dog.AttackPower = 8;
						Dog.CurrentHealth = 250;
						Player.CurrentHealth = 100;


						Console.WriteLine("You have approched a Dog!");
						Console.WriteLine("PLAYER ATTACK: " + Player.AttackPower + " HEALTH: " + Player.CurrentHealth);
						Console.WriteLine("Dog ATTACK: " + Dog.AttackPower + " HEALTH: " + Dog.CurrentHealth);
						Console.WriteLine("-----------------------------------------------");
						
						for (; ; )
						{
							if (Player.CurrentHealth < 0)
							{
								Console.Clear();
								Console.WriteLine("You died! Better luck next time..");
								Player.IsDead = true;

								break;
							}
							if (Dog.CurrentHealth < 0)
							{
								Console.Clear();
								battleCount++;
								startInventory.Items[5] = "War Boots = 15Attack";
								Console.WriteLine("The Dog is dead! Let's see new loot");
								Console.WriteLine("------------------------------");
								break;
							}
							Console.WriteLine("Enter 1 to attack");
							string attack = Console.ReadLine();
							if (attack == "1")
							{
								if (Dog.CurrentHealth <= 0)
								{
									Console.Clear();
									battleCount++;
									startInventory.Items[5] = "War Boots = 15Attack";
									Console.WriteLine("The Dog is dead! Let's see new loot");
									Console.WriteLine("------------------------------");
									break;
								}
								else
								{
									Random random = new Random();
									int playerRandom = random.Next(4);
									Random random2 = new Random();
									int enemyRandom = random2.Next(3);

									//Console.WriteLine("PlayerRan = " + playerRandom + " enemyRan = " + enemyRandom);
									Console.WriteLine("Dog HEALTH: " + (Dog.CurrentHealth -= (Player.AttackPower * playerRandom)));
									Console.WriteLine(Player.Name + " HEALTH: " + (Player.CurrentHealth -= (Dog.AttackPower * enemyRandom)));
								} 

							}
							else
							{
								Console.WriteLine("Please enter valid entry");
							}
						}
					} // Dog battle

					if (battleCount == 6)
					{
						Console.Clear();
						Character Goblin = new Character();
						Goblin.AttackPower = 10;
						Goblin.CurrentHealth = 270;
						Player.CurrentHealth = 100;


						Console.WriteLine("You have approched a Goblin!");
						Console.WriteLine("PLAYER ATTACK: " + Player.AttackPower + " HEALTH: " + Player.CurrentHealth);
						Console.WriteLine("Goblin ATTACK: " + Goblin.AttackPower + " HEALTH: " + Goblin.CurrentHealth);
						Console.WriteLine("-----------------------------------------------");
						for (; ; )
						{
							if (Player.CurrentHealth < 0)
							{
								Console.Clear();
								Console.WriteLine("You died! Better luck next time..");
								Player.IsDead = true;
								break;
							}
							if (Goblin.CurrentHealth < 0)
							{
								Console.Clear();
								battleCount++;
								startInventory.Items[6] = "War Gloves = 15Attack";
								Console.WriteLine("The Goblin is dead! Let's see new loot");
								Console.WriteLine("------------------------------");
								break;
							}
							Console.WriteLine("Enter 1 to attack");
							string attack = Console.ReadLine();
							if (attack == "1")
							{
								if (Goblin.CurrentHealth <= 0)
								{
									Console.Clear();
									battleCount++;
									startInventory.Items[6] = "War Gloves = 15Attack";
									Console.WriteLine("The Goblin is dead! Let's see new loot");
									Console.WriteLine("------------------------------");
									break;
								}
								else
								{
									Random random = new Random();
									int playerRandom = random.Next(4);
									Random random2 = new Random();
									int enemyRandom = random2.Next(3);

									//Console.WriteLine("PlayerRan = " + playerRandom + " enemyRan = " + enemyRandom);
									Console.WriteLine("Goblin HEALTH: " + (Goblin.CurrentHealth -= (Player.AttackPower * playerRandom)));
									Console.WriteLine(Player.Name + " HEALTH: " + (Player.CurrentHealth -= (Goblin.AttackPower * enemyRandom)));
								}

							}
							else
							{
								Console.WriteLine("Please enter valid entry");
							}
						}//
					} // Goblin battle

					if (battleCount == 8)
					{
						Console.Clear();
						Character Wizard = new Character();
						Wizard.AttackPower = 20;
						Wizard.CurrentHealth = 350;
						Player.CurrentHealth = 100;


						Console.WriteLine("You have approched a Wizard!");
						Console.WriteLine("PLAYER ATTACK: " + Player.AttackPower + " HEALTH: " + Player.CurrentHealth);
						Console.WriteLine("Wizard ATTACK: " + Wizard.AttackPower + " HEALTH: " + Wizard.CurrentHealth);
						Console.WriteLine("-----------------------------------------------");
						for (; ; )
						{
							if (Player.CurrentHealth < 0)
							{
								Console.Clear();
								Console.WriteLine("You died! Better luck next time..");
								Player.IsDead = true;
								break;
							}
							if (Wizard.CurrentHealth < 0)
							{
								Console.Clear();
								battleCount++;
								startInventory.Items[7] = "Wizard Potion = 20Attack";
								Console.WriteLine("The Wizard is dead! Let's see new loot");
								Console.WriteLine("------------------------------");
								break;
							}
							Console.WriteLine("Enter 1 to attack");
							string attack = Console.ReadLine();
							if (attack == "1")
							{
								if (Wizard.CurrentHealth <= 0)
								{
									Console.Clear();
									battleCount++;
									startInventory.Items[7] = "Wizard Potion = 20Attack";
									Console.WriteLine("The Wizard is dead! Let's see new loot");
									Console.WriteLine("------------------------------");
									break;
								}
								else
								{
									Random random = new Random();
									int playerRandom = random.Next(4);
									Random random2 = new Random();
									int enemyRandom = random2.Next(3);

									//Console.WriteLine("PlayerRan = " + playerRandom + " enemyRan = " + enemyRandom);
									Console.WriteLine("Wizard HEALTH: " + (Wizard.CurrentHealth -= (Player.AttackPower * playerRandom)));
									Console.WriteLine(Player.Name + " HEALTH: " + (Player.CurrentHealth -= (Wizard.AttackPower * enemyRandom)));
								}

							}
							else
							{
								Console.WriteLine("Please enter valid entry");
							}
						}//
					} // Wizard battle

					if (battleCount == 10)
					{
						Console.Clear();
						Character Boss1 = new Character();
						Boss1.AttackPower = 25;
						Boss1.CurrentHealth = 500;
						Player.CurrentHealth = 100;


						Console.WriteLine("You have approched GodZilla! He is a Boss. Good Luck!");
						Console.WriteLine("PLAYER ATTACK: " + Player.AttackPower + " HEALTH: " + Player.CurrentHealth);
						Console.WriteLine("Godzilla ATTACK: " + Boss1.AttackPower + " HEALTH: " + Boss1.CurrentHealth);
						Console.WriteLine("-----------------------------------------------");
						for (; ; )
						{
							if (Player.CurrentHealth < 0)
							{
								Console.Clear();
								Console.WriteLine("You died! Better luck next time..");
								Player.IsDead = true;
								break;
							}
							if (Boss1.CurrentHealth < 0)
							{
								Console.Clear();
								battleCount++;
								startInventory.Items[8] = "War Necklace = 20Attack";
								Console.WriteLine("The Godzilla is dead! Let's see new loot");
								Console.WriteLine("------------------------------");
								break;
							}
							Console.WriteLine("Enter 1 to attack or Enter 2 to use potion");
							string attack = Console.ReadLine();
							if (attack == "1")
							{
								if (Boss1.CurrentHealth <= 0)
								{
									Console.Clear();
									battleCount++;
									startInventory.Items[8] = "War Necklace = 20Attack";
									Console.WriteLine("The Godzilla is dead! Let's see new loot");
									Console.WriteLine("------------------------------");
									break;
								}
								else
								{
									Random random = new Random();
									int playerRandom = random.Next(4);
									Random random2 = new Random();
									int enemyRandom = random2.Next(3);

									//Console.WriteLine("PlayerRan = " + playerRandom + " enemyRan = " + enemyRandom);
									Console.WriteLine("Godzilla HEALTH: " + (Boss1.CurrentHealth -= (Player.AttackPower * playerRandom)));
									Console.WriteLine(Player.Name + " HEALTH: " + (Player.CurrentHealth -= (Boss1.AttackPower * enemyRandom)));
								}

							}
								else if (attack == "2")
								{
									Player.AttackPower += startInventory.AttackPower[6];
								Console.WriteLine("Potion used!" + "Attack power: " + Player.AttackPower);
								Console.WriteLine(Player.Name + " HEALTH: " + (Player.CurrentHealth -= Boss1.AttackPower));
								Console.WriteLine("      ");
								

							}
								else
							{
								Console.WriteLine("Please enter valid entry");
							}
						}//
					} // Boss battle

					if (battleCount == 12)
					{
						Console.Clear();
						Character Boss2 = new Character();
						Boss2.AttackPower = 28;
						Boss2.CurrentHealth = 550;
						Player.CurrentHealth = 100;


						Console.WriteLine("You have approched Big Boss (Final boss)! He is the last Boss. Good Luck!");
						Console.WriteLine("PLAYER ATTACK: " + Player.AttackPower + " HEALTH: " + Player.CurrentHealth);
						Console.WriteLine("Big Boss ATTACK: " + Boss2.AttackPower + " HEALTH: " + Boss2.CurrentHealth);
						Console.WriteLine("-----------------------------------------------");
						for (; ; )
						{
							if (Player.CurrentHealth < 0)
							{
								Console.Clear();
								Console.WriteLine("You died! Better luck next time..");
								Player.IsDead = true;
								break;
							}
							if (Boss2.CurrentHealth < 0)
							{
								Console.Clear();
								battleCount++;
								startInventory.Items[9] = "War Ring = 30Attack";
								Console.WriteLine("YAYYYYYY! You Won!");
								Console.WriteLine("------------------------------");
								Player.IsDead = true;
								break;
							}
							Console.WriteLine("Enter 1 to attack or Enter 2 to use potion");
							string attack = Console.ReadLine();
							if (attack == "1")
							{
								if (Boss2.CurrentHealth <= 0)
								{
									Console.Clear();
									battleCount++;
									startInventory.Items[9] = "War Ring = 30Attack";
									Console.WriteLine("The Big Boss is dead! Let's see new loot");
									Console.WriteLine("------------------------------");
									break;
								}
								else
								{
									Random random = new Random();
									int playerRandom = random.Next(4);
									Random random2 = new Random();
									int enemyRandom = random2.Next(3);

									//Console.WriteLine("PlayerRan = " + playerRandom + " enemyRan = " + enemyRandom);
									Console.WriteLine("Big Boss HEALTH: " + (Boss2.CurrentHealth -= (Player.AttackPower * playerRandom)));
									Console.WriteLine(Player.Name + " HEALTH: " + (Player.CurrentHealth -= (Boss2.AttackPower * enemyRandom)));
								}

							}
							else if (attack == "2")
							{
								Player.AttackPower += startInventory.AttackPower[6];
								Console.WriteLine("Potion used!" + "Attack power: " + Player.AttackPower);
								Console.WriteLine(Player.Name + " HEALTH: " + (Player.CurrentHealth -= Boss2.AttackPower));
								Console.WriteLine("      ");


							}
							else
							{
								Console.WriteLine("Please enter valid entry");
							}
						}//
					} // Boss2 battle



				} // Battles

				if (playerMenu == "3" || Player.IsDead == true) 
				{
					break;

				} // Exit game
				else
				{
					Console.WriteLine("Please enter valid number");
					Console.WriteLine("");
				}
				
			}
				Console.ReadLine();
		}
	}
}
