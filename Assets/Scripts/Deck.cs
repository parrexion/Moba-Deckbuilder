using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck : MonoBehaviour {

	public List<CardData> deck;
	public List<CardData> discard;

	private static System.Random rng = new System.Random();

	private void Start() {
		Shuffle();
	}

	public void Shuffle() {
		deck = deck.OrderBy(a => rng.Next()).ToList();
	}

	public CardData Draw() {
		if (deck.Count == 0) {
			for(int i = 0; i < discard.Count; i++) {
				deck.Add(discard[i]);
			}
			discard.Clear();
			Shuffle();
		}
		CardData data = deck[0];
		deck.RemoveAt(0);
		Debug.Log("CArd:   " + data.cardName);
		return data;
	}

	public void Discard(CardData data) {
		discard.Add(data);
	}
}
