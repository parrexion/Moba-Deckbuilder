using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class CardData : ScriptableObject {

	public Sprite icon;
	public string cardName;
	public int cost;
	public string effect;

}
