using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
	private string[] quotes = {"Press X to egg your neighbors' houses.", "Go on. You don't even like them.", "Splat splat splat", "You're a little jerk."};

	Text text;

	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> ();
		text.text =	quotes [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X) == true) {
			GetComponentInChildren<Text>().text = quotes[Random.Range(0,quotes.Length)];
		}
	}
}
