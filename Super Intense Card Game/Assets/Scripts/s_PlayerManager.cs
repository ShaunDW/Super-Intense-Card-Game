using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class s_PlayerManager : MonoBehaviour {

	public bool isAi;
	public s_DeckSetUp deckManager;
	public List<Card> PlayerDeck = new List<Card>();
	public List<Card> PlayerHand = new List<Card>();
	public List<Card> PlayerGrave = new List<Card>();
	public Card selectedCard;
	private int totalHandCount = 5;
	public int cardCount = 0;

	void Start(){
		deckManager = GameObject.Find("Deck Manager").GetComponent<s_DeckSetUp>();
	}

	public void StartDeck(){
		for(int a = 0; a < deckManager.DeckAllCards.Count; a++){
			int b = Random.Range(0, deckManager.DeckAllCards.Count);
			PlayerDeck.Add(deckManager.DeckAllCards[b]);
		}
		DrawHand();
		EventSystem.current.currentSelectedGameObject.SetActive(false);
	}

	public void DrawHand(){
		for(cardCount = 0; cardCount < totalHandCount; cardCount++){
			int b = Random.Range(0, PlayerDeck.Count);
			PlayerHand.Add(PlayerDeck[b]);
			PlayerDeck.RemoveAt(b);
		}
	}

	public void CardDraw(){
		if(cardCount < totalHandCount){
			int b = Random.Range(0, PlayerDeck.Count);
			PlayerHand.Add(PlayerDeck[b]);
			PlayerDeck.RemoveAt(b);
			cardCount++;
		} 
	}

	public void CardDead(Card deadCard){
		PlayerHand.Remove(deadCard);
		PlayerGrave.Add(deadCard);
		cardCount--;
	}
}