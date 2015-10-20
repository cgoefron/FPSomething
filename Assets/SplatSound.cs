using UnityEngine;
using System.Collections;

public class SplatSound : MonoBehaviour {

	public AudioSource splat;


	void update(){
		splat = GetComponent<AudioSource> ();
		
		splat.Play();

	}

	IEnumerator Example() {

		yield return new WaitForSeconds(splat.clip.length);

	//	Destroy (gameObject);
		print(Time.time);
	}


}
