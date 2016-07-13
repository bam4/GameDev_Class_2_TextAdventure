using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextAdventure2 : MonoBehaviour {


	string currentRoom = "in Front of the Great Pyramid."; // Remembers our current location in world
	bool hasDoorPart = false;
	bool hasStoneDoll = false;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		// If I declare a variable inside Update().
		// then I can ONLY use this variable inside Update() !!
		// also, a "buffer" is a staging area to prepare data
		string textBuffer = "You are currently " + currentRoom;

		if (currentRoom == "in Front of the Great Pyramid.") {
			// all your LOBBY code will go here later!
			// Typing "/n" in a string means "line break"
			textBuffer += "\nYou see the entrance to the pyramid.";
			textBuffer += "\nYou see the desert behind you.";
			// the line of code below is the SAME as the line of code above
			// textBuffer = textBuffer + "\nYou see the Parsons security guard.";
			textBuffer += "\nPresss [P] to go inside the pyramid.";
			textBuffer += "\nPress [D] to go into the desert.";

			if (Input.GetKeyDown (KeyCode.P)) { // if player pushes W...
				currentRoom = "in the Pyramid's Main Hall.";
			} else if (Input.GetKeyDown (KeyCode.D)) {
				currentRoom = "in the Desert.";
			}
		} else if (currentRoom == "in the Pyramid's Main Hall.") {	
			textBuffer += "\nYou see a door that leads to the pharoh's tomb.";

			if (hasDoorPart == false) {
				textBuffer += "\nWithout the missing piece, the door won't budge.";
				textBuffer += "\nPress [F] to go to the front of the pyramid.";
				if (Input.GetKeyDown (KeyCode.F))  // if player pushes W...
					currentRoom = "in Front of the Great Pyramid.";
				
			}   else {
				textBuffer += "\nYou place the Ankh into the door. It slides open.";
				textBuffer += "\nPresss [C] to enter the pharoh's tomb.";
				textBuffer += "\nPress [S] to go to the servant's quarters.";
				textBuffer += "\npress [F] to go to the front of the pyramid.";
				if (Input.GetKeyDown (KeyCode.F)) { // if player pushes W...
					currentRoom = "in Front of the Great Pyramid.";
				} else if (Input.GetKeyDown (KeyCode.S)) {
					currentRoom = "in the Servants' Quarters.";
				} else if (Input.GetKeyDown (KeyCode.C)) {
					currentRoom = "in the Pharoh's Tomb.";
				}
			}
		} else if (currentRoom == "in the Desert.") {
			textBuffer += "\nThe desert sands blow around you.";
			if (hasDoorPart == false) {
				textBuffer += "\nYou see a golden Ankh jutting out from the sand.";
				textBuffer += "\nPress [A] to pick it up.";
				if (Input.GetKeyDown (KeyCode.A)) 
					hasDoorPart = true;
			}
			textBuffer += "\nPress [F] to go to the front of the pyramid.";
			if (Input.GetKeyDown (KeyCode.F)) {
				currentRoom = "in Front of the Great Pyramid.";
			}
				
			// all your ELEVATORS code will go here
		} else if (currentRoom == "in the Servants' Quarters.") {
			textBuffer += "\nThe room is the size of a small closet.";
			textBuffer += "\nIts four cots rotted away long ago.";
			if (hasStoneDoll == false) {
				textBuffer += "\nYou see a stone doll with an intricate dress on the ground.";
				textBuffer += "\nPress [G] to pick it up.";
				if (Input.GetKeyDown (KeyCode.G)) {
					hasStoneDoll = true;
				}
			}
			textBuffer += "\nPress [P] to go to the pyramid's main hall.";
			if (Input.GetKeyDown (KeyCode.P))  // if player pushes W...
				currentRoom = "in the Pyramid's Main Hall.";	
				// all your OUTSIDE code will go here later!
		} else if (currentRoom == "in the Pharoh's Tomb.") {
			textBuffer += "\nYou enter the Pharoh's tomb.";
			textBuffer += "\nThe Pharoh's tomb has long been excavated, so he is gone.";
			textBuffer += "\nHowever, the princess's tomb is still intact.";
			textBuffer += "\nNo one has been able to figure out how to open it.";
			if (hasStoneDoll == false) {
				textBuffer += "\nPress [F] to go to the front of the pyramid.";
				if (Input.GetKeyDown (KeyCode.F))  // if player pushes W...
					currentRoom = "in Front of the Great Pyramid.";
			} else {
				textBuffer = "";
				textBuffer += "\nYou place the stone doll at the bottom of the princess's tomb.";
				textBuffer += "\nA rumbling comes from within the the tomb. The princess's mummy bursts out and grabs the doll.";
				textBuffer += "\nWhen the princess notices that the stone doll's dress has decayed, she glares at you.";
				textBuffer += "\nYou run out of there as fast as you can!";
				textBuffer += "\nThe End.";
			}
	}
			// all your OUTSIDE code will go here later!	
		// lets "render out" our text buffer and display it on-screen
		// we need to do this at the end otherwise we'll display text too soon
		GetComponent <Text>().text = textBuffer;
	} // CLOSES OUT UPDATE () scope
}