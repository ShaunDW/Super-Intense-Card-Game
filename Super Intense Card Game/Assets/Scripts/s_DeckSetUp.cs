using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class s_DeckSetUp : MonoBehaviour {
	
	public List<Card> DeckAllCards = new List<Card>();

	void Start(){
		InitialiseCards();
	}

	void InitialiseCards(){
		//Humans
		DeckAllCards.Add(new Card(SpeciesType.Human, "Archer", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Human, "Soldier", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Human, "Scout", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Human, "Sniper", 5, 2, 7, 6, 4));

		// Orcs
		DeckAllCards.Add(new Card(SpeciesType.Orc, "Archer", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Orc, "Soldier", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Orc, "Scout", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Orc, "Sniper", 5, 2, 7, 6, 4));

		// Elves
		DeckAllCards.Add(new Card(SpeciesType.Elf, "Archer", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Elf, "Soldier", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Elf, "Scout", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Elf, "Sniper", 5, 2, 7, 6, 4));

		// Aliens
		DeckAllCards.Add(new Card(SpeciesType.Alien, "Archer", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Alien, "Soldier", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Alien, "Scout", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Alien, "Sniper", 5, 2, 7, 6, 4));

		// Monsters
		DeckAllCards.Add(new Card(SpeciesType.Monster, "Archer", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Monster, "Soldier", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Monster, "Scout", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Monster, "Sniper", 5, 2, 7, 6, 4));

		// Loners
		DeckAllCards.Add(new Card(SpeciesType.Loner, "Leader", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Loner, "Outlaw", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Loner, "Wonderer", 5, 2, 7, 6, 4));
		DeckAllCards.Add(new Card(SpeciesType.Loner, "Brute", 5, 2, 7, 6, 4));
	}
}
