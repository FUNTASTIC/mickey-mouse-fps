using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other)
    {
		if(other.name != "Mickey" &&
			other.name != "First Person Controller" &&
			other.name != "Crosshair" &&
			other.tag != "Bullet")
		{
			GameObject.Destroy(this.gameObject);
			Debug.Log ("Hit " + other.name);
		}
	}
}
