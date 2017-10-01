using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO.Ports;


public class Kamehamehabehaviour : MonoBehaviour {
	
	public ChargeBlueBehaviour ChargeBluePrefab;
	public ChargeRedBehaviour ChargeRedPrefab;
	private string Released = "no";
	private Vector3 Kamehamehadirection;
	// Use this for initialization
	public PlasmaExplosionBehaviour PlasmaExplosionPrefab;
	public VolcanoBehaviour Volcano;


	void Start () {
		

	}


	





	void Update () {
		// // additional stuff if not using bluetooth
			//if (Input.GetButton ("Fire1") && Released == "no") { 


		// fire the kamehakema 
		if((	ControllerForGlove.Handstate.Contains("handclosed") && Released == "no" ) ){
			transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2;
		} else {
			if (Released == "no") {
				Kamehamehadirection = (Camera.main.transform.forward * 40);
			}
			transform.Translate ((Kamehamehadirection) * Time.deltaTime);
			Released = "yes";

			ChargeBluePrefab.gameObject.SetActive(false);

			ChargeRedPrefab.gameObject.SetActive (false);
		}
	}
	//different things are triggered if it hits different objects.
 	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Volcano")) {
			PlasmaExplosionPrefab.transform.position = transform.position;
			Instantiate (PlasmaExplosionPrefab);

			Instantiate(Volcano);
			Destroy (gameObject);
			
		}
		if (other.gameObject.CompareTag ("Terrain")) {
			PlasmaExplosionPrefab.transform.position = transform.position;
			Instantiate (PlasmaExplosionPrefab);
			Destroy (gameObject);
		}
	}

}
