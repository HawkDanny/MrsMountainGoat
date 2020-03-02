using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrmhlRead : MonoBehaviour {


	public GameManager gameMan;

	wrmhl myDevice = new wrmhl(); // wrmhl is the bridge beetwen your computer and hardware.

	[Tooltip("SerialPort of your device.")]
	public string portName = "COM8";

	[Tooltip("Baudrate")]
	public int baudRate = 250000;


	[Tooltip("Timeout")]
	public int ReadTimeout = 20;

	[Tooltip("QueueLength")]
	public int QueueLength = 1;

	void Start () {
		myDevice.set (portName, baudRate, ReadTimeout, QueueLength); // This method set the communication with the following vars;
		//                              Serial Port, Baud Rates, Read Timeout and QueueLenght.
		myDevice.connect (); // This method open the Serial communication with the vars previously given.
	}

	// Update is called once per frame
	void Update () {
		gameMan.input = myDevice.readQueue();
	}

	void OnApplicationQuit() { // close the Thread and Serial Port
		myDevice.close();
	}
}
