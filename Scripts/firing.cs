using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO.Ports;
using TechTweaking.Bluetooth;
using UnityEngine.UI;

public class firing: MonoBehaviour {
	public Kamehamehabehaviour KamehamehaPrefab;
	public Kamehamehabehaviour Kamehamehaspawned;
	public Text Mode;



	private string Lasthandstate = "handopen";
	// additional stuff if not using bluetooht
	//arduino sensor
	// public static string Handstate = "hand";
	//SerialPort Glove = new SerialPort("COM5", 57600);



	void Start () {


	}



	void Update () {
		// additional stuff if not using bluetooht
		//arduino serial
		//Handstate = Glove.ReadLine (); 


		// check if handstate is now handclosed. if it is. started a KAMEHAMEHA
		if (ControllerForGlove.Handstate.Contains("handclosed") && Lasthandstate.Contains("handopen")) {
			
			KamehamehaPrefab.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2;
			Kamehamehaspawned = Instantiate (KamehamehaPrefab);

		}
		Lasthandstate = ControllerForGlove.Handstate;


	}
}

