using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class StandingController : MonoBehaviour {

	public Text leftAText;
	public Text leftBText;
	public Text rightAText;
	public Text rightBText;

	public int leftA;
	public int leftB;
	public int rightA;
	public int rightB;

	private void Start() {
		UpdateTexts();
	}

	private void UpdateTexts() {

		leftAText.text = leftA.ToString();
		leftBText.text = leftB.ToString();
		rightAText.text = rightA.ToString();
		rightBText.text = rightB.ToString();
	}

	public void ChangeLeftA(int diff) {
		leftA += diff;
		leftAText.text = leftA.ToString();
	}
	public void ChangeLeftB(int diff) {
		leftB += diff;
		leftBText.text = leftB.ToString();
	}
	public void ChangeRightA(int diff) {
		rightA += diff;
		rightAText.text = rightA.ToString();
	}
	public void ChangeRightB(int diff) {
		rightB += diff;
		rightBText.text = rightB.ToString();
	}

	public void Fight(int lane) {
		int aDeath = 0, bDeath = 0;
		if (lane == 0) {
			StringBuilder b = new StringBuilder();
			for(int i = 0; i < leftA; i++) {
				int r = Random.Range(1, 7);
				b.Append(r + ", ");
				if(r > 3)
					bDeath++;
			}
			Debug.Log("A: " + b.ToString());

			b = new StringBuilder();
			for(int i = 0; i < leftB; i++) {
				int r = Random.Range(1, 7);
				b.Append(r + ", ");
				if(r > 3)
					aDeath++;
			}
			Debug.Log("B: " + b.ToString());

			leftA = Mathf.Max(0, leftA - aDeath);
			leftB = Mathf.Max(0, leftB - bDeath);
		}
		else if(lane == 1) {
			StringBuilder b = new StringBuilder();
			for(int i = 0; i < rightA; i++) {
				int r = Random.Range(1, 7);
				b.Append(r + ", ");
				if(r > 3)
					bDeath++;
			}
			Debug.Log("A: " + b.ToString());

			b = new StringBuilder();
			for(int i = 0; i < rightB; i++) {
				int r = Random.Range(1, 7);
				b.Append(r + ", ");
				if(r > 3)
					aDeath++;
			}
			Debug.Log("B: " + b.ToString());

			rightA = Mathf.Max(0, rightA - aDeath);
			rightB = Mathf.Max(0, rightB - bDeath);
		}
		UpdateTexts();
	}
}
