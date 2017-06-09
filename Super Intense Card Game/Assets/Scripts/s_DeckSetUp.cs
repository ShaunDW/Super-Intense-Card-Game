using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class s_DeckSetUp : MonoBehaviour {
	
	public List<Card> DeckAllCardsPlayer = new List<Card>();
	public List<Card> DeckAllCardsAI = new List<Card>();

	void Start(){
		InitialiseCards();
	}

	void InitialiseCards(){ 
		////////// Player ////////

		//Humans
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Human, "Archer", 5, 2, 7, 6, 4));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Human, "Soldier", 6, 6, 8, 6, 7));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Human, "Scout", 3, 2, 3, 6, 5));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Human, "Sniper", 5, 2, 7, 8, 4));

		// Orcs
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Orc, "Archer", 1, 2, 3, 4, 5));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Orc, "Soldier", 5, 4, 2, 1, 3));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Orc, "Scout", 7, 8, 4, 3, 1));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Orc, "Sniper", 2, 3, 7, 8, 4));

		// Elves
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Elf, "Archer", 7, 6, 9, 2, 5));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Elf, "Soldier", 2, 3, 5, 6, 4));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Elf, "Scout", 5, 2, 7, 6, 4));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Elf, "Sniper", 5, 2, 4, 8, 4));

		// Loners
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Loner, "Leader", 4, 7, 8, 8, 4));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Loner, "Outlaw", 6, 2, 7, 6, 4));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Loner, "Wonderer", 7, 2, 7, 4, 6));
		DeckAllCardsPlayer.Add(new Card(SpeciesType.Loner, "Brute", 3, 4, 9, 2, 7));

		//////////// AI /////////

		//Humans
		DeckAllCardsAI.Add(new Card(SpeciesType.Human, "Archer", 5, 2, 7, 6, 4));
		DeckAllCardsAI.Add(new Card(SpeciesType.Human, "Soldier", 6, 6, 8, 6, 7));
		DeckAllCardsAI.Add(new Card(SpeciesType.Human, "Scout", 3, 2, 3, 6, 5));
		DeckAllCardsAI.Add(new Card(SpeciesType.Human, "Sniper", 5, 2, 7, 8, 4));

		// Orcs
		DeckAllCardsAI.Add(new Card(SpeciesType.Orc, "Archer", 1, 2, 3, 4, 5));
		DeckAllCardsAI.Add(new Card(SpeciesType.Orc, "Soldier", 5, 4, 2, 1, 3));
		DeckAllCardsAI.Add(new Card(SpeciesType.Orc, "Scout", 7, 8, 4, 3, 1));
		DeckAllCardsAI.Add(new Card(SpeciesType.Orc, "Sniper", 2, 3, 7, 8, 4));

		// Elves
		DeckAllCardsAI.Add(new Card(SpeciesType.Elf, "Archer", 7, 6, 9, 2, 5));
		DeckAllCardsAI.Add(new Card(SpeciesType.Elf, "Soldier", 2, 3, 5, 6, 4));
		DeckAllCardsAI.Add(new Card(SpeciesType.Elf, "Scout", 5, 2, 7, 6, 4));
		DeckAllCardsAI.Add(new Card(SpeciesType.Elf, "Sniper", 5, 2, 4, 8, 4));

		// Loners
		DeckAllCardsAI.Add(new Card(SpeciesType.Loner, "Leader", 4, 7, 8, 8, 4));
		DeckAllCardsAI.Add(new Card(SpeciesType.Loner, "Outlaw", 6, 2, 7, 6, 4));
		DeckAllCardsAI.Add(new Card(SpeciesType.Loner, "Wonderer", 7, 2, 7, 4, 6));
		DeckAllCardsAI.Add(new Card(SpeciesType.Loner, "Brute", 3, 4, 9, 2, 7));
	}
}
