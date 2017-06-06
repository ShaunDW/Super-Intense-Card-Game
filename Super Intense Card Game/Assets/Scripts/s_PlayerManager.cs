using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class s_PlayerManager : MonoBehaviour {

	public s_DeckSetUp deckManager;
	public List<Card> PlayerDeck = new List<Card>();
	public List<Card> PlayerHand = new List<Card>();
	public int handCount;

	void Start(){
		deckManager = GameObject.Find("Deck Manager").GetComponent<s_DeckSetUp>();
	}

	public void StartDeck(){
		for(int a = 0; a < deckManager.DeckAllCards.Count; a++){
			int b = Random.Range(0, deckManager.DeckAllCards.Count);
			PlayerDeck.Add(deckManager.DeckAllCards[b]);
		}
	}

	public void DrawHand(){
		if(PlayerDeck.Count == 0){
			print("No cards in deck");
		}
		else {
			for(int a = 0; a < handCount; a++){
				int b = Random.Range(0, handCount);
				PlayerHand.Add(PlayerDeck[b]);
				PlayerDeck.RemoveAt(b);
			}
		}
	}
}