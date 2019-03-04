using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

	public List<CardData> availableCards = new List<CardData>();
	public Card[] offerings;
	public Deck deck;


	private void Start() {
		for(int i = 0; i < offerings.Length; i++) {
			offerings[i].Setup(availableCards[0]);
			availableCards.RemoveAt(0);
		}
	}

	public void BuyCard(int index) {
		CardData card = offerings[index].Extract();
		deck.Discard(card);
		offerings[index].Setup(availableCards[0]);
		availableCards.RemoveAt(0);
	}
}
