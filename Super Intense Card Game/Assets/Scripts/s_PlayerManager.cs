using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class s_PlayerManager : MonoBehaviour {

	public s_DeckSetUp deckManager;
	public s_AttackManager attackManager;
	public List<Card> PlayerDeck = new List<Card>();
	public List<Card> PlayerHand = new List<Card>();
	public List<Card> PlayerGrave = new List<Card>();
	public List<Card> AiDeck = new List<Card>();
	public List<Card> AiHand = new List<Card>();
	public List<Card> AiGrave = new List<Card>();
	public Card selectedCard, aiSelectedCard;
	private int totalHandCount = 5;
	public int cardCount = 0;
	public int aiCardCount = 0;
	private bool hasEnded = false;

	void Start(){
		deckManager = GameObject.Find("Deck Manager").GetComponent<s_DeckSetUp>();
		attackManager = GameObject.Find("Attack Manager").GetComponent<s_AttackManager>();
	}

	public void StartDeck(){
		for(int a = 0; a < deckManager.DeckAllCardsPlayer.Count; a++){
			int b = Random.Range(0, deckManager.DeckAllCardsPlayer.Count);
		//	if(!PlayerDeck.Contains(deckManager.DeckAllCardsPlayer[b])){
		//		print(deckManager.DeckAllCardsPlayer[b].species + " " +deckManager.DeckAllCardsPlayer[b].cardName);
				PlayerDeck.Add(deckManager.DeckAllCardsPlayer[b]);
				deckManager.DeckAllCardsPlayer.RemoveAt(b);
		//	} 
		}
		for(int a = 0; a < deckManager.DeckAllCardsAI.Count; a++){
			int b = Random.Range(0, deckManager.DeckAllCardsAI.Count);
			if(!PlayerDeck.Contains(deckManager.DeckAllCardsAI[b])){
				AiDeck.Add(deckManager.DeckAllCardsAI[b]);
				deckManager.DeckAllCardsAI.RemoveAt(b);
			}
		} 
		DrawHand();
		DrawAiHand();
		EventSystem.current.currentSelectedGameObject.SetActive(false);
	}

	//Player

	public void DrawHand(){
		for(cardCount = 0; cardCount < totalHandCount; cardCount++){
			int b = Random.Range(0, PlayerDeck.Count);
			PlayerHand.Add(PlayerDeck[b]);
			PlayerDeck.RemoveAt(b);
		}
	}

	public void CardDraw(){
		if(PlayerDeck.Count > 0){
			if(cardCount < totalHandCount){
				int b = Random.Range(0, PlayerDeck.Count);
				PlayerHand.Add(PlayerDeck[b]);
				PlayerDeck.RemoveAt(b);
				cardCount++;
			} 
		} 
	}
		

	public void CardDead(Card deadCard){
		PlayerHand.Remove(deadCard);
		PlayerGrave.Add(deadCard);
		cardCount--;
		CardDraw();
	}

	//Ai 

	public void DrawAiHand(){
		for(aiCardCount = 0; aiCardCount < totalHandCount; aiCardCount++){
			int b = Random.Range(0, AiDeck.Count);
			AiHand.Add(AiDeck[b]);
			AiDeck.RemoveAt(b);
		}
	}

	public void AiCardDraw(){
		if(AiDeck.Count > 0){
			if(aiCardCount < totalHandCount){
				int b = Random.Range(0, AiDeck.Count);
				AiHand.Add(AiDeck[b]);
				AiDeck.RemoveAt(b);
				aiCardCount++;
			}		
		} 
	}

	public void AiCardDead(Card deadCard){
		AiHand.Remove(deadCard);
		AiGrave.Add(deadCard);
		aiCardCount--;
		AiCardDraw();
	}



	public void TempSelectCards(){
		bool playerCard = false;
		bool aiCard = false;
		if(!hasEnded){
			if(PlayerHand.Count > 0){
				int chosenCard = Random.Range(0, PlayerHand.Count);
				selectedCard = PlayerHand[chosenCard];
				playerCard = true;
			}
			if(AiHand.Count > 0){
				int chosenAiCard = Random.Range(0, AiHand.Count);
				aiSelectedCard = AiHand[chosenAiCard];
				aiCard = true;
			}
			if(playerCard && aiCard){
				attackManager.Attack();
			} 
		}
	}

	public void CheckDefeated(){
		if(PlayerHand.Count == 0 && PlayerDeck.Count == 0){
			print("PLAYER HAS NO CARDS. AI WINS");
			hasEnded = true;
		}  if(AiHand.Count == 0 && AiDeck.Count == 0){
			print("AI HAS NO CARDS. PLAYER WINS");
			hasEnded = true;
		}
	}

}