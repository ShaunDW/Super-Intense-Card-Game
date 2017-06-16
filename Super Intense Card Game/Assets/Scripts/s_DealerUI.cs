using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class s_DealerUI : MonoBehaviour {

	[SerializeField] public GameObject cardPrefab;
	public Vector2 botCenterScreenSpace;
	public Vector3 botCenterWorldSpace;
	public float totalWidth;


	// Use this for initialization
	void Start () {
		botCenterScreenSpace = new Vector2(Screen.width/2, 0);
		botCenterWorldSpace = Camera.main.ScreenToWorldPoint(new Vector3(botCenterScreenSpace.x, botCenterScreenSpace.y, Camera.main.nearClipPlane));
	}
	
	public void OnCardsDrawn(List<Card> cardsDrawn)
	{
		for(int i = 0; i < cardsDrawn.Count; i++)
		{
			Vector3 cardPosition = this.botCenterWorldSpace + new Vector3(totalWidth + (totalWidth/cardsDrawn.Count*i) + cardPrefab.transform.localScale.x/2, 0, 0);

			GameObject newCardUi = (GameObject)Instantiate(this.cardPrefab, cardPosition , Quaternion.identity);
			newCardUi.transform.localRotation = Quaternion.Euler(-90f, 0, 0);
			newCardUi.transform.position = new Vector3(newCardUi.transform.position.x, 2, 2);
		}
	}
}
