using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

		List<IItem> inventory = new List<IItem>();

		Sword sword = new Sword("Long Sword", 12, 5);
		Axe axe = new Axe("Battle Axe", 20, 10);
		Shield shield = new Shield("Wooden Shield", 5, 2);
		Potion healthPotion = new Potion("Health", 1);

		sword.Attack();

		// line break
		Console.WriteLine();

		axe.Attack();

		// line break
		Console.WriteLine();

		shield.Block();

		// line break
		Console.WriteLine();

		healthPotion.UsePotion();

		// add items to the inventory
		inventory.AddItem(inventory, sword);


    Console.ReadLine();
  }
}

// Interface
public interface IItem
{
	string Name { get; set; }
	int SellValue { get; set; }

	void AddItem();
}

// Abctract Class
public abstract class Weapon
{
	public string Name { get; set; }
	public int Damage { get; set; }
	public int SellValue { get; set; }

	public void Attack()
	{
		Console.WriteLine($"You have attacked with the { Name } and did { Damage } amount of damage.");
	}
}

// Items
public class Sword : Weapon, IItem
{
	public Sword(string name, int damage, int sellValue)
	{
		Name = name;
		Damage = damage;
		SellValue = sellValue;
	}

	public void AddItem(List<IItem> inventory, IItem item)
	{
		inventory.Add(item);
		Console.WriteLine($"A { Name } was added to your inventory.");
	}
}

public class Axe : Weapon, IItem
{
	public Axe(string name, int damage, int sellValue)
	{
		Name = name;
		Damage = damage;
		SellValue = sellValue;
	}

	public void AddItem(List<IItem> inventory, IItem item)
	{
		inventory.Add(item);
	}
}

public class Shield : IItem
{
	public string Name { get; set; }
	public int Defence { get; set; }
	public int SellValue { get; set; }

	public Shield(string name, int defence, int sellValue)
	{
		Name = name;
		Defence = defence;
		SellValue = sellValue;
	}

	public void Block()
	{
		Console.WriteLine($"Your { Name } blocked { Defence } damage.");
	}

	public void AddItem(List<IItem> inventory, IItem item)
	{
		inventory.Add(item);
	}
}

public class Potion : IItem
{
	public string Name { get; set; }
	public int SellValue { get; set; }

	public Potion(string name, int sellValue)
	{
		Name = name;
		SellValue = sellValue;
	}

	public void UsePotion()
	{
		Console.WriteLine($"You have used a { Name } potion.");
	}

	public void AddItem(List<IItem> inventory, IItem item)
	{
		inventory.Add(item);
	}
}


