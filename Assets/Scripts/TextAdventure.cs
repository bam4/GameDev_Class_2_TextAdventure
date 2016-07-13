using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextAdventure : MonoBehaviour {


	string currentRoom = "The 3rd Circle of Hell - Gluttony"; // Remembers our current location in world
	bool hasGoldenCoin = false;
	bool hasSpokenWithPerson = false;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		// If I declare a variable inside Update().
		// then I can ONLY use this variable inside Update() !!
		// also, a "buffer" is a staging area to prepare data
		string textBuffer = "You are currently in: " + currentRoom;

		if (currentRoom == "3rd Circle of Hell - Gluttony") {
			// all your LOBBY code will go here later!
			// Typing "/n" in a string means "line break"
			textBuffer += "\n FROSTY: Happy birthday! Hey, I said my first words. But... But snowmen can't talk. Ha ha ha, come on now, what's the joke? Could I really be alive?";
			// the line of code below is the SAME as the line of code above
			// textBuffer = textBuffer + "\nYou see the Parsons security guard.";
			textBuffer += "\npresss [W] to go to elevators";
			textBuffer += "\npress [S] to go outside.";

			if (Input.GetKeyDown (KeyCode.W)) { // if player pushes W...
				currentRoom = "Elevators";
			} else if (Input.GetKeyDown (KeyCode.S)) {
				currentRoom = "Outside";
			}
		} else if (currentRoom == "Elevators" ) {	
			
		} else if (currentRoom == "Elevators") {
			// all your ELEVATORS code will go here
		} else if (currentRoom == "Outside") {
			// all your OUTSIDE code will go here later!
		}
		// lets "render out" our text buffer and display it on-screen
		// we need to do this at the end otherwise we'll display text too soon
		GetComponent <Text>().text = textBuffer;
	} // CLOSES OUT UPDATE () scope
}
