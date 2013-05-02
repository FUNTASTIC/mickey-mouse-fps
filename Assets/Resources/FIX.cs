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
		if (col.CompareTag("Player")) {
			Debug.Log("Mickey got his fix!");
			GameObject m = GameObject.Find("Mickey");
			m.SendMessage("GetMyFixOn", 10); 
			GameObject.Destroy(this.gameObject);
		}
	}
}
