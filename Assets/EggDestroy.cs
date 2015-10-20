using UnityEngine;
using System.Collections;

public class EggDestroy : MonoBehaviour {

	public GameObject eggSplatImg; //replace with Splat effect?
	public Rigidbody rb;
	public float thrust;


	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		rb.AddForce(transform.forward * thrust);


	}

		void OnTriggerEnter(Collider other) {
			Debug.Log ("Collider triggered. " + other.name);
			
			if (other.tag == "Boundary")
			{
			Destroy (gameObject);
		}
		/*
			if (other.tag == "Splattable") {

			Instantiate (eggSplatImg, transform.position, transform.rotation);				
				//Application.LoadLevel(Application.loadedLevel); //Move restart to other condition
			}
			*/
		Instantiate (eggSplatImg, transform.position, transform.rotation);	
		//GetComponent<AudioSource>().Play (); 
		Destroy (gameObject);
		}


}
