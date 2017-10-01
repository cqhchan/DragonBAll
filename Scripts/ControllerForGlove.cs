using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TechTweaking.Bluetooth;
using UnityEngine.UI;

public class ControllerForGlove : MonoBehaviour
{
	//used a bluetooth asset from unity store. 
	private BluetoothDevice device;
	public static string Handstate = "handopen";

	private int checkclosed = 0;
	private int checkopen = 0;
	void Awake() {

		// if bluetooth off, enable it
		BluetoothAdapter.askEnableBluetooth ();

		device = new BluetoothDevice ();
		device.setEndByte (10);
		//specific to my arduino bluetooth mac address
		device.MacAddress = "00:06:66:D0:C9:65";

		device.connect ();


	}
	
	void Start(){

	

	}

	void Update ()
	{
		//read the data the arduino sending
		byte[] msg = device.read();

				if (msg != null && msg.Length > 0) {
			Handstate = System.Text.ASCIIEncoding.ASCII.GetString (msg);

	
				}
		}
}
	


