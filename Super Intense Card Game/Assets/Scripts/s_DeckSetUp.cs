using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class s_DeckSetUp : MonoBehaviour {
	public enum SpeciesType{
		Human,
		Orc,
		Elf,
		Alien,
		Monster
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

	public List<Card> Deck = new List<Card>();

	void Start(){
		PopulateDeck();
	}

	void PopulateDeck(){
		//Humans
		Deck.Add(new Card(SpeciesType.Human, "Archer", 5, 2, 7, 6, 4));
		Deck.Add(new Card(SpeciesType.Human, "Axe Man", 5, 2, 7, 6, 4));
		Deck.Add(new Card(SpeciesType.Human, "Scout", 5, 2, 7, 6, 4));
		Deck.Add(new Card(SpeciesType.Human, "Sniper", 5, 2, 7, 6, 4));

		//Orcs

		//Elves

		//Aliens

		//Monsters
	}
}
