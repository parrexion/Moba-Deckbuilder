using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {

	public CardData data;
	public Text cardName;
	public Text cost;
	public Text effect;


	public void Setup(CardData card) {
		Debug.Log("Card:   " + card.cardName);
		data = card;
		cardName.text = card.cardName;
		cost.text = card.cost.ToString();
		effect.text = card.effect;
	}

	public CardData Extract() {
		CardData card = data;
		cardName.text = "";
		cost.text = "";
		effect.text = "";

		return card;
	}
}
