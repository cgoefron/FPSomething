using UnityEngine;
using System.Collections;

public class rayShooter : MonoBehaviour {

	public float rayDistance = 5;

	// Use this for initialization
	void Start () {
		print ("howdy");
		Debug.LogError ("yes this is a greeting");
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hitInfo;
		//Ray fromHereToThere origin direction
		//Debug.DrawRay (transform.position, transform.up); //Debug only drawn in scene while playing
		//if something is rayDistance away from this object from the front
		if ( Physics.Raycast( transform.position, transform.forward, out hitInfo, rayDistance ) ) {
			Debug.Log ( "you've hit the thing named: " + hitInfo.collider.name );
			hitInfo.collider.GetComponent<packTextures>().changeTexture();
		}
		}
	

	void OnDrawGizmos(){
		Gizmos.color = Color.red;
			Gizmos.DrawRay (transform.position, transform.forward * rayDistance); //Gizmos show up even when not in Play mode
		//Gizmos.color = Color.blue;
		//    Gizmos.DrawSphere (transform.position, 3);


	}
}
