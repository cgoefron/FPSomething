using UnityEngine;
using System.Collections;

public class packTextures : MonoBehaviour {

	public Texture[] textures;
	Texture2D combined;
	int currentTexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeTexture(){
		currentTexture += 1;
		currentTexture = currentTexture % textures.Length; //take the remainder after dividing; 
		/* if (currentTexture >= textures.Length) {
			currentTexture = 0;
		} */

		GetComponent<Renderer> ().material.mainTexture = textures [1];
	}
}
