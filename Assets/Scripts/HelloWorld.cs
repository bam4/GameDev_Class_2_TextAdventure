using UnityEngine;
using System.Collections;

using UnityEngine.UI;
//This line will let your code to the text.

	public class HelloWorld : MonoBehaviour {

	public Text myTextObject;

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello world");

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Bonjour Monde");

		myTextObject.text = "Hola Mundo";
	}
}
