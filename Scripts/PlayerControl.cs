using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	private Vector3 movement;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// control player movements.

		if (Input.GetButton("Fire1")){
		movement = Camera.main.transform.forward * 8;
		transform.Translate ((movement) * Time.deltaTime);
		}
	}
}
