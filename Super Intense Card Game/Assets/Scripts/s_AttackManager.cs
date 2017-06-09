using UnityEngine;
using System.Collections;

public class s_AttackManager : MonoBehaviour {

	public Card playerCard, aiCard;
	public CardStat statToCompare;

	public void Start(){
		
	}

	public void Attack()
	{
		if (playerCard[(int)statToCompare] > aiCard[(int)statToCompare])
		{
			GUILayout.Label("Player Wins with " + playerCard.cardName + " against " + aiCard.cardName + " in " + statToCompare.ToString());
		}
		else if (playerCard[(int)statToCompare] == aiCard[(int)statToCompare])
		{
			GUILayout.Label("There's a draw with " + playerCard.cardName + " against " + aiCard.cardName + " in " + statToCompare.ToString());
		}
		else
		{
			GUILayout.Label("AI Wins with " + aiCard.cardName + " against " + playerCard.cardName + " in " + statToCompare.ToString());
		}
	}
}
