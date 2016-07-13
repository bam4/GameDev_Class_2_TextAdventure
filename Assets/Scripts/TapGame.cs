using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TapGame : MonoBehaviour {

	public Text myTextObject2;

	int currentPoints = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Give player one point if they press space.
		if (Input.GetKeyDown (KeyCode.Space)) {
			currentPoints += 1;
			myTextObject2.text = "Current Score: " + currentPoints.ToString();
		}

		// Provide win condition.
		if (currentPoints >= 15) {
			myTextObject2.text = "Congratulations, you win!";
		}
		if (Input.GetKeyDown ((KeyCode.Y))) {
			currentPoints += 500;
		}
	}
}
