using UnityEngine;
using System.Collections;

public class s_AttackManager : MonoBehaviour {

	public s_PlayerManager playerManager;
	public Card playerCard, aiCard;
	public CardStat statToCompare;

	public void Start(){
		playerManager = GameObject.Find("Player Manager").GetComponent<s_PlayerManager>();

	}

	public void Attack() {
		playerCard = playerManager.selectedCard;
		aiCard = playerManager.aiSelectedCard; 
		if (playerCard[(int)statToCompare] > aiCard[(int)statToCompare])
		{
			print("Player Wins with " + playerCard.species + " " + playerCard.cardName + " against " + aiCard.species + " " + aiCard.cardName + " in " + statToCompare.ToString());
			playerManager.AiCardDead(playerManager.aiSelectedCard);
		}
		else if (playerCard[(int)statToCompare] == aiCard[(int)statToCompare])
		{
			print("There's a draw with " + playerCard.species + " " + playerCard.cardName + " against " + aiCard.species + " " + aiCard.cardName + " in " + statToCompare.ToString());
		}
		else
		{
			print("AI Wins with " + aiCard.species + " " + aiCard.cardName + " against " + playerCard.species + " " + playerCard.cardName + " in " + statToCompare.ToString());
			playerManager.CardDead(playerManager.selectedCard);
		}	
		playerManager.CheckDefeated();
	}
}
