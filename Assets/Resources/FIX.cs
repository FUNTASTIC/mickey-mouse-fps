using UnityEngine;
using System.Collections;

public class FIX : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col) {
		print ("Im hitting something");
		if (col.CompareTag("Mickey")) {
			((FixMeter)col.GetComponent("FixMeter")).GetMyFixOn(1);
		}
	}
}
