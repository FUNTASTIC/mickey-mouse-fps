using UnityEngine;
using System.Collections;

public class Bullet_Impact : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col) {
		GameObject.Instantiate(Resources.Load("Magic_Hit"), this.transform.position, this.transform.rotation);
		// if hits enemy and they die, create blood
		if (col.tag == "Enemy" /* && col.GetComponent<"AI">().isDead()*/) {
			GameObject.Instantiate(Resources.Load("Blood"), this.transform.position, this.transform.rotation);
		}
	}
}
