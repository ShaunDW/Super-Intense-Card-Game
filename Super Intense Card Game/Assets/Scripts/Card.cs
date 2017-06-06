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
	}

