using UnityEngine;
using System.Collections;

public class EggShooter : MonoBehaviour {

	public float rayDistance = 5;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	
	private float nextFire;

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

//		RaycastHit hitInfo;
//	if ( Physics.Raycast( transform.position, transform.forward, out hitInfo, rayDistance ) ) {
//			Debug.Log ( "you've hit the thing named: " + hitInfo.collider.name );
		//			hitInfo.collider.GetComponent<packTextures>().changeTexture();}

		
			if (Input.GetKeyDown("x") && Time.time > nextFire) 
			{
			Instantiate(shot, shotSpawn.position, Camera.main.transform.rotation);

		        nextFire = Time.time + fireRate;
				
			}
		//Debug.Log (shotSpawn.rotation);
		}

//	void OnDrawGizmos(){
//		Gizmos.color = Color.red;
//		Gizmos.DrawRay (transform.position, transform.forward * rayDistance); //Gizmos show up even when not in Play mode
		//Gizmos.color = Color.blue;
		//    Gizmos.DrawSphere (transform.position, 3);
		
		
}
	

