using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour {

	[Header("Left")]
	public int position = 3;
	public bool[] towers;
	public Image[] towerRep;
	public Image positionToken;

	[Header("Right")]
	public int positionB = 3;
	public bool[] towersB;
	public Image[] towerRepB;
	public Image positionTokenB;


	private void Start() {
		UpdateMap();
	}

	public void Move(int dir) {
		if(towers[position + dir]) {
			towers[position + dir] = false;
		}
		else {
			position += dir;
		}
		UpdateMap();
	}

	public void MoveB(int dir) {
		if(towersB[positionB + dir]) {
			towersB[positionB + dir] = false;
		}
		else {
			positionB += dir;
		}
		UpdateMap();
	}

	private void UpdateMap() {
		positionToken.transform.SetParent(towerRep[position].transform);
		positionToken.transform.localPosition = Vector3.zero;
		for(int i = 0; i < towerRep.Length; i++) {
			towerRep[i].enabled = towers[i];
		}

		positionTokenB.transform.SetParent(towerRepB[positionB].transform);
		positionTokenB.transform.localPosition = Vector3.zero;
		for(int i = 0; i < towerRepB.Length; i++) {
			towerRepB[i].enabled = towersB[i];
		}
	}
}
