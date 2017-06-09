using UnityEngine;
using System.Collections;

public enum SpeciesType{
	Human,
	Orc,
	Elf,
	Alien,
	Monster,
	Loner
};

public enum CardStat{
	Health = 0,
	Armour = 1,
	Attack = 2,
	Intelligence = 3,
	Stamina = 4
};

[System.Serializable]
public class Card{
	public SpeciesType species;
	public string cardName;
	public int health;
	public int armour;
	public int attack;
	public int intelligence;
	public int stamina;	

	public Card(SpeciesType spec, string name, int hp, int arm, int at, int intel, int stam){
		species = spec;
		cardName = name;			
		health = hp;
		armour = arm;
		attack = at;
		intelligence = intel;
		stamina = stam;
	}

	public int this[int index]
	{
		get
		{
			switch (index)
				{
					case (int)CardStat.Health:
				{
					return health;
				}
					case (int)CardStat.Armour:
				{
					return armour;
				}
					case (int)CardStat.Attack:
				{
					return attack;
				}
					case (int)CardStat.Intelligence:
				{
					return intelligence;
				}
					case (int)CardStat.Stamina:
				{
					return stamina;
				}
					default:
				{
					return -1;
				}
			}
		}
	}
}

