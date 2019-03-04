using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

	public Transform cardPrefab;
	public Deck deck;
	public List<Card> hand = new List<Card>();


	private void Start() {
		cardPrefab.gameObject.SetActive(false);
	}

	public void DrawCard() {
		CardData data = deck.Draw();
		Transform card = Instantiate(cardPrefab, transform);
		card.gameObject.SetActive(true);
		Card c = card.GetComponent<Card>();
		c.Setup(data);
		hand.Add(c);
	}

	public void DiscardHand() {
		for(int i = hand.Count - 1; i >= 0; i--) {
			deck.Discard(hand[i].data);
			Destroy(hand[i].gameObject);
			Debug.Log("D_   " + i);
		}
		hand.Clear();
	}
}
